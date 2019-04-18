using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IniParser;
using IniParser.Model;

namespace T4Browser
{
    public partial class Player_Options : Form
    {
        bool game_path_set = false;
        public Server_Browser browse;
        public Player_Options(Server_Browser browser)
        {
            InitializeComponent();
            this.browse = browser;
            browse.Hide();


    

        }

        private void Player_Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            browse.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).SelectedIndex != 0)
                MessageBox.Show("This doesn't sync yet.");

            int sel_char = ((ComboBox)sender).SelectedIndex+1;
            string num = sel_char.ToString();

            if (sel_char < 10)
                num = "0" + sel_char;

           
            character_picture.Image = Image.FromFile("Players\\OSG_"+num+"model.png");
        }

        private void Player_Options_Load(object sender, EventArgs e)
        {
            character_select.SelectedIndex = 0;
            HorzSens.SelectedIndex = 4;
            VertSens.SelectedIndex = 4;
            GamePathText.Text = "Not Set!";

            if (browse.PlayerName != null)
                player_name.Text = browse.PlayerName;

            if (browse.GamePath != null)
            {
                GamePathText.Text = browse.GamePath;
                game_path_set = true;
            }

        }

        private void SetGamePathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog odiag = new OpenFileDialog();
            odiag.DefaultExt = ".exe";
            odiag.CheckFileExists = true;
            odiag.CheckPathExists = true;
            odiag.Filter = "Turok 4 Game|Turok4.exe";
            odiag.ShowDialog();

            GamePathText.Text = odiag.FileName;
            browse.GamePath = GamePathText.Text;
            string directory = Path.GetDirectoryName(odiag.FileName);
            browse.GameDir = directory;

            if (!File.Exists(directory+"/t4mp.dll") || !File.Exists(directory+"/T4MP.exe") || !File.Exists(directory+"\\T4MP\\multiplayerjoin.ati"))
            {
                DialogResult dialogResult = MessageBox.Show("The Turok:Evolution MP mod was not found to be installed!\r\n\r\nWould you like the browser to install it?", "Warning - MOD NOT FOUND!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Copy("Mods/t4mp.dll", directory + "/t4mp.dll",true);
                    File.Copy("Mods/T4MP.exe", directory + "/T4MP.exe",true); // This is a modified exe which will load t4mp.dll, this way we don't overwrite the original.
                    File.Copy("Mods/d3d9.dll", directory + "/d3d9.dll", true); // have to be careful with this one, though it mostly fixes bugs.
                    File.Copy("Mods/D3dHook.dll", directory + "/D3dHook.dll", true);
                    File.Copy("Mods/hook.ini", directory + "/hook.ini", true); // This will have to be modified later to have the appropriate path.
                    Directory.CreateDirectory(directory + "/T4MP");
                    File.Copy("Mods/multiplayerjoin.ati", directory + "T4MP/multiplayerjoin.ati",true);
                    File.Copy("Mods/mutliplayerjoin.txm", directory + "data/text/mutliplayerjoin.txm", true);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("You won't be able to play without the mod installed!");
                }
            }

            game_path_set = true;


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (game_path_set == false)
               MessageBox.Show("Not saving!\r\nSet the path to Turok4.exe first!");

            var parser = new FileIniDataParser();
            IniData data = new IniData();
            data["browser"]["game_path"] = browse.GamePath;
            data["browser"]["player_name"] = player_name.Text;
            parser.WriteFile("T4Browser.ini", data);

            browse.PlayerName = player_name.Text;

            this.Close();
        }
    }
}
