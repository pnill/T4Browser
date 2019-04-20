using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Google.Protobuf.Pack;
using Google.Protobuf;
using static Google.Protobuf.Pack.Packet.Types.Type;
using static Google.Protobuf.Pack.game_option.Types.Type;
using static Google.Protobuf.Pack.host_snap.Types.Type;
using static Google.Protobuf.Pack.Packet;
using System.Collections.Concurrent;
using IniParser;
using IniParser.Model;
using System.Diagnostics;


namespace T4Browser
{
    public partial class Lobby : Form
    {
        public SynchronizedCollection<TcpClient> clients = new SynchronizedCollection<TcpClient>();
        Server_Browser browser = null;
        Host_Server host_form = null;
        Lobby_Server lobby_server = null;
        Lobby_Client lobby_client = null;
        public Packet Host_Options_Pack = null;
        int players_in_server = 0;
        int map_id = 0;

        string IP_Address = "";
        int remote_port = 0;
        string name = "";
        public string player_name = "";
        bool host = false;

        Thread server_thread = null;
        Thread connect_thread = null;


        public Lobby(string LobbyName, Server_Browser browser, string ip, int port, bool ishost, Host_Server hostf = null)
        {
            InitializeComponent();

            this.Text = "Server Lobby - " + LobbyName;
            this.name = LobbyName;
            this.browser = browser;
            this.IP_Address = ip;
            this.remote_port = port;
            this.host = ishost;
            this.host_form = hostf;
            this.player_name = browser.PlayerName;

        }

        public void AddPlayer(string name, NetworkStream clientStream = null,bool update = false)
        {
            players_in_server++;
            playerlist.Items.Add(name);

            if (update == false)
                chat_box.AppendText("[Server Notice]: " + name + " has joined the lobby!\r\n");

            player_count.Text = "Players: " + players_in_server + " / 16";

            if (host)
            {
               player player_pack = new player();
               player_pack.Name = name;

               lobby_server.PlayerToPack.Add(name, player_pack);

               Host_Options_Pack.LobbySnapshot.Players.Add(player_pack);
               Host_Options_Pack.LobbySnapshot.SnapType = TJoin;
               Host_Options_Pack.Type = HostSnapshot;
               Host_Options_Pack.WriteDelimitedTo(clientStream);
              

            }
        }

        public void RemovePlayer(string name,player player_pack = null)
        {
            players_in_server--;
            playerlist.Items.Remove(name);
            chat_box.AppendText("[Server Notice]: " + name + " has left the lobby!\r\n");

            player_count.Text = "Players: " + players_in_server + " / 16";


            if (host)
            {
                Host_Options_Pack.LobbySnapshot.Players.Remove(player_pack);
                lobby_server.PlayerToPack.Remove(name);

                Packet quit_pack = new Packet();
                quit_pack.Type = QuitMessage;
                quit_pack.PlayerStatus = player_pack;

                lobby_server.SendPacketToAll(quit_pack);
            }
        }

        public void UpdateLobby(Packet pack)
        {
            /*
             * We just joined
             * Make sure we grab existing players.
             */

            if (pack.LobbySnapshot.SnapType == TJoin)
            {
                foreach (player player_pack in pack.LobbySnapshot.Players)
                {
                    if (player_pack.Name != player_name)
                        AddPlayer(player_pack.Name, null, true);
                }
            }
            else
            {
                AddChatText("Server Notice", "The host has updated game options!");
            }

            /* Whether we're just joining or host changed options, we need to update this */
            frag_text.Text = pack.LobbySnapshot.FragLimit.ToString();
            time_limit_text.Text = pack.LobbySnapshot.TimeLimit.ToString();
            map_text.Text = pack.LobbySnapshot.MapName.ToString();
            player_count.Text = "Players: " + players_in_server + " / 16";
            map_id = pack.LobbySnapshot.MapId;

            foreach(game_option goption in pack.LobbySnapshot.Options)
            {
                switch(goption.OptionType)
                {
                    case OGamePlay:
                        GameOptions_List.SetItemChecked(goption.Index, goption.Option);
                    break;

                    case OWeaponAvail:
                        WeaponAllowed_List.SetItemChecked(goption.Index, goption.Option);
                    break;

                    case OWeaponSpawn:
                        WeaponSpawn_List.SetItemChecked(goption.Index, goption.Option);
                     break;

                    
                }
            }

            switch(pack.LobbySnapshot.GameType)
            {
                case 2:
                    type_text.Text = "Death Match";
                break;
            }

        }

        public void UpdateHostLobby(bool update = true)
        {
            Host_Options_Pack = new Packet();
            Host_Options_Pack.LobbySnapshot = new Google.Protobuf.Pack.host_snap();

            frag_text.Text = host_form.set_frag_limit.ToString();
            time_limit_text.Text = host_form.set_time_limit.ToString();
            map_text.Text = host_form.set_map.Text;
            type_text.Text = host_form.set_gametype.Text;

            // Since the packet gets re-created we need to re-add all the players
            if (lobby_server != null)
            {
                foreach (KeyValuePair<string, player> player_entry in lobby_server.PlayerToPack)
                {
                    Host_Options_Pack.LobbySnapshot.Players.Add(player_entry.Value);
                }
            }

            player player_pack = new player();
            player_pack.Name = player_name;
            Host_Options_Pack.LobbySnapshot.Players.Add(player_pack);
            

            if (!update)
            {
                players_in_server++;
                playerlist.Items.Add(player_name);
            }


            player_count.Text = "Players: "+(playerlist.Items.Count)+" / " + host_form.set_player_limit;

  
            Host_Options_Pack.LobbySnapshot.FragLimit = host_form.set_frag_limit;
            Host_Options_Pack.LobbySnapshot.TimeLimit = host_form.set_time_limit;
            Host_Options_Pack.LobbySnapshot.MapName = map_text.Text;
            Host_Options_Pack.LobbySnapshot.GameType = 2; // Place holder, we only support death match for now.
            Host_Options_Pack.LobbySnapshot.MapId = host_form.set_map.SelectedIndex;

            for (int i = 0; i < host_form.game_option.Items.Count; i++)
            {
                game_option goption = new game_option();
                goption.OptionType = OGamePlay;
                goption.Index = i;

                if (host_form.game_option.GetItemChecked(i))
                {
                    goption.Option = true;
                    GameOptions_List.SetItemChecked(i, true);
                }
                else
                {
                    goption.Option = false;
                    GameOptions_List.SetItemChecked(i, false);
                }

                Host_Options_Pack.LobbySnapshot.Options.Add(goption);

            }

            for (int i = 0; i < host_form.weapon_available.Items.Count; i++)
            {
                game_option goption = new game_option();
                goption.OptionType = OWeaponAvail;
                goption.Index = i;

                if (host_form.weapon_available.GetItemChecked(i))
                {
                    goption.Option = true;
                    WeaponAllowed_List.SetItemChecked(i, true);
                }
                else
                {
                    goption.Option = false;
                    WeaponAllowed_List.SetItemChecked(i, false);
                }

                Host_Options_Pack.LobbySnapshot.Options.Add(goption);
            }

            for (int i = 0; i < host_form.weapon_spawn.Items.Count; i++)
            {
                game_option goption = new game_option();
                goption.OptionType = OWeaponSpawn;
                goption.Index = i;

                if (host_form.weapon_spawn.GetItemChecked(i))
                {
                    goption.Option = true;
                    WeaponSpawn_List.SetItemChecked(i, true);
                }
                else
                {
                    goption.Option = false;
                    WeaponSpawn_List.SetItemChecked(i, false);
                }

                Host_Options_Pack.LobbySnapshot.Options.Add(goption);
            }

            if (update)
            {
                Host_Options_Pack.LobbySnapshot.SnapType = TUpdate;
                Host_Options_Pack.Type = HostSnapshot;
                lobby_server.SendPacketToAll(Host_Options_Pack);
            }

        }

        private void ClientConnect()
        {
            var parser = new FileIniDataParser();
            IniData data = new IniData();
            data["T4MP"]["server"] = "0";
            data["T4MP"]["server_ip"] = IP_Address;
            data["T4MP"]["port"] = remote_port.ToString(); // Game uses UDP where browser uses TCP so port re-use is fine.
            parser.WriteFile(browser.GameDir + "/T4MP.ini", data,Encoding.ASCII);

            lobby_client = new Lobby_Client(this, IP_Address, remote_port);
            lobby_client.Connect();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            if (host == false)
            {
                menuStrip1.Enabled = false;
                chat_box.Text = "Attempting to connect to server " + name + " at" + IP_Address + ":" + remote_port + "\r\n";

                connect_thread = new Thread(ClientConnect);
                connect_thread.Start();
            }
            else
            {


                chat_box.Text = "You are the host, choose host options to change game options before launching.\r\n";
                UpdateHostLobby(false);

                server_thread = new Thread(HostServer);
                server_thread.Start();
            }

        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (server_thread != null)
            {
                lobby_server.Stop();
            }

            if(connect_thread != null)
            {
                lobby_client.Disconnect();
            }

            if (host)
                host_form.RemoveServer();

            browser.Show();
        }

        private void game_options_group_Enter(object sender, EventArgs e)
        {

        }

  
        public void AddChatText(string PlayerName, string message)
        {
            chat_box.AppendText("[" + PlayerName + "]: " + message + "\r\n");
        }

        private void HostServer()
        {
            var parser = new FileIniDataParser();
            IniData data = new IniData();
            data["T4MP"]["server"] = "1";
            data["T4MP"]["port"] = remote_port.ToString();
            parser.WriteFile(browser.GameDir + "/T4MP.ini", data,Encoding.ASCII);

            lobby_server = new Lobby_Server(this, remote_port);
            lobby_server.Listen();   
        }

        private void editGameSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (player_name == "")
            {
                MessageBox.Show("Set player options first!");
                return;
            }

            if (host_form != null)
                host_form.Show();
        }

        private void send_text_Click(object sender, EventArgs e)
        {
            if (chat_text.Text.Length > 0)
            {
                chat_packet chat_pack = new chat_packet
                {
                    Name = browser.PlayerName,
                    Message = chat_text.Text
                };

                Packet chat_pack_parent = new Packet
                {
                    Type = ChatMessage,
                    Chat = chat_pack.Clone()
                };


                if (host)
                {
                    lobby_server.SendPacketToAll(chat_pack_parent);
                    AddChatText(browser.PlayerName, chat_text.Text);
                }
                else
                    lobby_client.SendPacket(chat_pack_parent);

                chat_text.Text = "";

            }      
         
        }

        private void chat_box_TextChanged(object sender, EventArgs e)
        {
            RichTextBox thisbox = (RichTextBox)sender;
            thisbox.SelectionStart = thisbox.Text.Length;
            thisbox.ScrollToCaret();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chat_packet chat_pack = new chat_packet
            {
                Name = "Server Notice",
                Message = "The host is starting the game..."
            };

            Packet chat_pack_parent = new Packet
            {
                Type = ChatMessage,
                Chat = chat_pack.Clone()
            };

            lobby_server.SendPacketToAll(chat_pack_parent);

            AddChatText("Server Notice", "Starting the game...");

            var startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = browser.GameDir;
            startInfo.FileName = browser.GameDir + "\\T4MP.exe";
            Process.Start(startInfo);

            /* Tell others to start game after...
             * Should possibly get some IPC going to only tell others to start after level load in-case host has slow PC.
             * That or force the client games to freeze the player in place and broadcast a 'connecting' message on the screen.
             */
            Packet sgame_pack = new Packet();
            sgame_pack.Type = StartGame;

            lobby_server.SendPacketToAll(sgame_pack);
        }

        public void GameStart()
        {
            History hist = new History(browser.GameDir);
            hist.map_id = map_id;
            hist.Save(GameOptions_List,WeaponAllowed_List,WeaponSpawn_List);

            var startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = browser.GameDir;
            startInfo.FileName = browser.GameDir + "\\T4MP.exe";
            Process.Start(startInfo);

           
        }
    }



}
