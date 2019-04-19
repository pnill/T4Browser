using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Pack;
using Google.Protobuf;
using static Google.Protobuf.Pack.Packet.Types.Type;
using static Google.Protobuf.Pack.host_snap.Types.Type;
using static Google.Protobuf.Pack.Packet;
using System.Net.Sockets;
using System.Net;

namespace T4Browser
{
    class ProcessPacket
    {
        Lobby lobby;
        Lobby_Server lobby_server;
        bool ishost;

        public ProcessPacket(Lobby lobbyptr,bool host, Lobby_Server hlobby = null)
        {
            lobby = lobbyptr;
            ishost = host;
            lobby_server = hlobby;
        }

        public void ReadData(Socket client_sock)
        {
            Packet pack;
            NetworkStream clientStream = null;
            try
            {
                clientStream = new NetworkStream(client_sock);
                pack = Packet.Parser.ParseDelimitedFrom(clientStream);
            }
            catch (Exception)
            {
                return;
            }

            string PlayerName;

            switch (pack.Type)
            {

                case QuitMessage:
                    lobby.Invoke(() =>
                    {
                        lobby.RemovePlayer(pack.PlayerStatus.Name, pack.PlayerStatus);
                    });
                break;

                case HostSnapshot:
                     lobby.Invoke(() =>
                     {
                         lobby.UpdateLobby(pack);
                      });
                break;

                case JoinMessage:

                    PlayerName = pack.PlayerStatus.Name;

                    lobby.Invoke(() =>
                    {
                        lobby.AddPlayer(PlayerName,clientStream);
                    });

                    if (ishost)
                    {
                        //Create socket->player map to remove them and track them by name for chat and such.
                        lobby_server.PlayerSocketMap.Add(client_sock, PlayerName);

                        lobby_server.SendPacketToAll(pack);
                    }
                break;


                case ChatMessage:
                    PlayerName = pack.Chat.Name;
                    if (ishost)
                    {
                        PlayerName = lobby_server.PlayerSocketMap[client_sock];

                        //Send packet to all other players.
                        pack.Chat.Name = PlayerName;
                        lobby_server.SendPacketToAll(pack);
                    }

                    lobby.Invoke(() =>
                    {
                        lobby.AddChatText(PlayerName, pack.Chat.Message);
                    });

                    break;

                case StartGame:

                break;
            }
        }
    }
}
