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
    class Lobby_Client
    {
        ProcessPacket process_packet = null;
        Lobby lobby = null;
        Socket client_socket = null;

        string IP;
        int port;


        public Lobby_Client(Lobby lobbyptr, string remote_ip, int remote_port)
        {
            lobby = lobbyptr;
            IP = remote_ip;
            port = remote_port;
            process_packet = new T4Browser.ProcessPacket(lobbyptr, false);
        }

        public void Connect()
        {
            client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client_socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            }
            catch (Exception ex)
            {
                lobby.Invoke(() =>
                {
                    lobby.Close();
                });
                return;
            }

            if (client_socket.Connected)
            {
                Packet pack = new Packet();
                pack.Type = JoinMessage;
                pack.PlayerStatus = new player();

                pack.PlayerStatus.Name = lobby.player_name;

                SendPacket(pack);
            }

            while (client_socket.IsConnected())
            {
                process_packet.ReadData(client_socket);
            }

            lobby.Invoke(() =>
            {
                lobby.Close();
            });

        }

        public void Disconnect()
        {
            if (client_socket.IsConnected() && client_socket.Connected)
                client_socket.Disconnect(false);
        }

        public void SendPacket(Packet Pack)
        {

            using (var clientStream = new NetworkStream(client_socket))
            {
                Pack.WriteDelimitedTo(clientStream);
            }

        }
    }


}
