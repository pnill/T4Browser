using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using IniParser;
using IniParser.Model;
using System.Net.NetworkInformation;

namespace T4Browser
{
    public partial class Server_Browser : Form
    {
        public Lobby lobby = null;
        public Player_Options player_options = null;
        public string PlayerName;
        public string GamePath;
        public string GameDir;
        public Server_Browser()
        {
            InitializeComponent();

            RefreshServers();

            //dataGridView1.Rows.Add("Tweeks server","100","0/8","Deathmatch","Oasis","127.0.0.1:9001");
            //dataGridView1.Rows.Add("Tweeks server 2", "50", "0/8", "Deathmatch", "Oasis", "127.0.0.1:1000");


        }

        public static double PingTimeAverage(string host, int echoNum)
        {
            long totalTime = 0;
            int timeout = 120;
            Ping pingSender = new Ping();

            for (int i = 0; i < echoNum; i++)
            {
                PingReply reply = pingSender.Send(host, timeout);
                if (reply.Status == IPStatus.Success)
                {
                    totalTime += reply.RoundtripTime;
                }
            }
            return totalTime / echoNum;
        }

        public void RefreshServers()
        {
            // this is an absolutely horrible thing to do security wise but, I'm being lazy.
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://t4mp.thedefaced.org/server_list.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                List<Server_Details> server_details = JsonConvert.DeserializeObject<List<Server_Details>>(result);

                foreach (Server_Details server in server_details)
                {

                    string ping = PingTimeAverage(server.ip_address, 4).ToString();
                    dataGridView1.Rows.Add(server.server_name, ping, server.player_count.ToString() + " / " + server.max_players.ToString(), server.game_type, server.map_name, server.ip_address + ":" + server.port);
                }

            }

       

    }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(PlayerName == null)
            {
                MessageBox.Show("You need to set the Player Options up first!");
                return;
            }

            string ServerName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            DataGridViewCellCollection cells = dataGridView1.Rows[e.RowIndex].Cells;

            if (lobby != null)
                lobby.Close();
                Server_Browser.ActiveForm.Hide();

            var net_address = cells[5].Value.ToString().Split(':');


            lobby = new Lobby(ServerName,this,net_address[0],Convert.ToInt32(net_address[1].ToString()),false);
            lobby.Show();
           
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1) // 1 is the ping column
            {
                int ping = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[1];

                if ( ping > 90)
                {
                    cell.Style = new DataGridViewCellStyle { ForeColor = Color.DarkRed };                   
                }

                if(ping > 20 && ping < 90)
                { 
                    cell.Style = new DataGridViewCellStyle { ForeColor = Color.DarkGreen };
                }


            }

        }

        private void Server_Browser_Load(object sender, EventArgs e)
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("T4Browser.ini");
                this.GamePath = data["browser"]["game_path"];
                this.GameDir = Path.GetDirectoryName(this.GamePath);
                this.PlayerName = data["browser"]["player_name"];
            }catch(Exception ex){
                
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshServers();
        }

        private void hostServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PlayerName == null)
            {
                MessageBox.Show("You need to set the Player Options up first!");
                return;
            }

            Host_Server host = new Host_Server(this);
            host.Show();

        }

        private void playerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            player_options = new Player_Options(this);
            player_options.Show();
        }

        private void gameOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null,"This isn't implemented yet!\r\nEventually we'll have control options, full-screen, windowed, etc.","Not done yet!");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }
    }
}
