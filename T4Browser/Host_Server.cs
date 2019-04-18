using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace T4Browser
{
    public partial class Host_Server : Form
    {
        Server_Browser browser = null;
        bool hosting = false;
        public int set_player_limit = 0;
        public int set_frag_limit = 0;
        public int set_time_limit = 0;

        public ComboBox set_map;
        public ComboBox set_gametype;
        public CheckedListBox weapon_available;
        public CheckedListBox weapon_spawn;
        public CheckedListBox game_option;



        public Host_Server(Server_Browser browser)
        {
            InitializeComponent();
            this.browser = browser;

            if (browser.lobby != null)
                browser.lobby.Close();

            browser.Hide();          
        }

        private void WeaponSet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Host_Server_Load(object sender, EventArgs e)
        {
            if (hosting == false)
            {
                for (int i = 0; i < WeaponSet.Items.Count; i++)
                {
                    WeaponSet.SetItemChecked(i, true);
                }

                for (int i = 0; i < WeaponSpawn.Items.Count; i++)
                {
                    WeaponSpawn.SetItemChecked(i, true);
                }

                map_select.SelectedIndex = 0;
                GameTypeCombo.SelectedIndex = 0;
                player_limit.SelectedIndex = 3;
            }
        }

        private void map_select_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            int map_sel_id = ((ComboBox)sender).SelectedIndex + 1;
            mapimage.Image = Image.FromFile("Maps\\OSG_multiplayer"+map_sel_id.ToString()+"map.png");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server_Details server_detail = new Server_Details
            {
                game_type = "Death Match",
                map_name = map_select.Items[map_select.SelectedIndex].ToString(),
                max_players = Convert.ToInt32(player_limit.Text),
                player_count = 1,
                server_name = ServerName.Text,
                port = Convert.ToInt32(ServerPort.Text)
            };

            string server_detail_serialized = JsonConvert.SerializeObject(server_detail);

            // this is an absolutely horrible thing to do security wise but, I'm being lazy.
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; }; 

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://t4mp.thedefaced.org/create_server.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(server_detail_serialized);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if(result == "-1")
                {
                    MessageBox.Show("That server name is invalid please do not include symbols!");
                    return;
                }
            }



            History hist = new History(browser.GameDir);
            hist.map_id = map_select.SelectedIndex;
            hist.time_limit = time_limit.Text;
            hist.frag_limit = frag_limit.Text;
           

            hist.Save(gameTypeOptions,WeaponSet,WeaponSpawn);

            set_frag_limit = Convert.ToInt32(frag_limit.Text);
            set_time_limit = Convert.ToInt32(time_limit.Text);
            set_player_limit = Convert.ToInt32(player_limit.Text);
            set_gametype = GameTypeCombo;
            set_map = map_select;

            weapon_available = WeaponSet;
            weapon_spawn = WeaponSpawn;
            game_option = gameTypeOptions;

            if (hosting == false)
            {
                if (browser.lobby != null)
                    browser.lobby.Close();

                browser.lobby = new Lobby(ServerName.Text, browser, "localhost", Convert.ToInt32(ServerPort.Text), true, this);
                this.Hide();
                this.Text = "Editing Server Options";
                StartLobby.Text = "Edit Game Options";
                hosting = true;
                browser.lobby.Show();
            }
            else
            {
                if (browser.lobby == null)
                    MessageBox.Show("Something went seriously wrong!");

                browser.lobby.UpdateHostLobby();
                this.Hide();
            }
        }

        private void gameTypeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void WeaponSpawn_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Host_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hosting == false)
                browser.Show();
            else
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    Hide();
                }
            }
        }

        public void RemoveServer()
        {
            Server_Details server_detail = new Server_Details
            {
                game_type = "Death Match",
                map_name = map_select.Items[map_select.SelectedIndex].ToString(),
                max_players = Convert.ToInt32(player_limit.Text),
                player_count = 1,
                server_name = ServerName.Text,
                port = Convert.ToInt32(ServerPort.Text)
            };

            string server_detail_serialized = JsonConvert.SerializeObject(server_detail);

            // this is an absolutely horrible thing to do security wise but, I'm being lazy.
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://t4mp.thedefaced.org/remove_server.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(server_detail_serialized);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if (result == "-1")
                {
                    //MessageBox.Show("That server name is invalid please do not include symbols!");
                    return;
                }
            }

            this.Close();

        }

        private void ServerPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
