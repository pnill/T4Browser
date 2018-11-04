using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Pack;
using Google.Protobuf;
using static Google.Protobuf.Pack.Packet.Types.Type;
using static Google.Protobuf.Pack.Packet;
using System.Net.Sockets;
using System.Net;

namespace T4Browser
{
    class Lobby_Server
    {
        Lobby lobby_form = null;
        ProcessPacket process_packet = null;
        Socket listener_sock = null;
        int host_port = 0;
        bool sock_listen;

        List<Socket> ConnectedSockets = new List<Socket>(); // this should be replaced with something thread-safe, it's accessed from the UI thread.
        public Dictionary<Socket, string> PlayerSocketMap = new Dictionary<Socket, String>();
        public Dictionary<string, player> PlayerToPack = new Dictionary<string, player>();

        public Lobby_Server(Lobby lobbyptr,int port)
        {
            lobby_form = lobbyptr;
            host_port = port;
            process_packet = new ProcessPacket(lobbyptr, true, this);
        }

        public void SendPacketToAll(Packet pack)
        {
            foreach(Socket client in ConnectedSockets)
            {
                using (var client_stream = new NetworkStream(client))
                {
                    pack.WriteDelimitedTo(client_stream);
                }
            }
        }

        public void Listen()
        {
            this.sock_listen = true;

            listener_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener_sock.Bind(new IPEndPoint(IPAddress.Any, host_port));
            listener_sock.Listen(16);

                 
            while (lobby_form.Visible)
            {
                List<Socket> ReadList = new List<Socket>(ConnectedSockets);
                List<Socket> ErrorList = new List<Socket>(ConnectedSockets);
                ReadList.Add(listener_sock);


                Socket.Select(ReadList, null, ErrorList, 1000);
         


                foreach (Socket client_sock in ReadList)
                {

                    if (client_sock == listener_sock)
                        ConnectedSockets.Add(client_sock.Accept());
                    else
                    {
                        if (client_sock.Available > 0)
                            process_packet.ReadData(client_sock);
                        else
                            ErrorList.Add(client_sock);

                    }
                }

                foreach (Socket client_sock in ErrorList)
                {
                        ConnectedSockets.Remove(client_sock);
                        string PlayerName = PlayerSocketMap[client_sock];
                        player player_pack = PlayerToPack[PlayerName];

                        PlayerSocketMap.Remove(client_sock);

                        lobby_form.Invoke(() =>
                        {
                            lobby_form.RemovePlayer(PlayerName, player_pack);
                        });
                }
         
            }

            foreach(Socket client in ConnectedSockets)
            {
                if(client.Connected)
                    client.Close();

                    client.Dispose();
            }

            listener_sock.Close();
            listener_sock.Dispose();
        }

        public void Stop()
        {
            this.sock_listen = false;
        }


    }
}
