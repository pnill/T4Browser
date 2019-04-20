using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

/* 
 * I'm sure there are much better ways to handle saving these options. Including modifying an INI parsing engine or something of the sort to support this... or writing my own parsers.
 * At this point though I've decided I just want to get an initial draft of the project going and can make those improvements later.
 */

namespace T4Browser
{
    class History
    {
        public int map_id = 1;
        public int game_type = 0;
        public string frag_limit = "15";
        public string time_limit = "0";
        
        // int was_flight = 0;
        FileStream mp_hist;
        FileStream mp_advoptions;
        FileStream mp_arsenal;

        public History(string game_path)
        {
            try
            {
                /* The official install of the game sets these files as read only this will remove that attribute */
                File.SetAttributes(game_path + "\\data\\history\\multiplayer.hst", FileAttributes.Normal);
                File.SetAttributes(game_path + "\\data\\history\\multiadvancedoptions.hst", FileAttributes.Normal);
                File.SetAttributes(game_path + "\\data\\history\\multiarsenal.hst", FileAttributes.Normal);

                mp_hist = File.Open(game_path + "\\data\\history\\multiplayer.hst", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                mp_advoptions = File.Open(game_path + "\\data\\history\\multiadvancedoptions.hst", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                mp_arsenal = File.Open(game_path + "\\data\\history\\multiarsenal.hst", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);

            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred while trying to save settings to the game!\r\nPlease ensure you have the appropriate permissions to write to the folder.\r\nAborting!\r\nError: "+ex.Message);
                Application.Exit();
            }
        }


        int GetCheckedOption(CheckedListBox listbox,int index)
        {
            return Convert.ToInt32(listbox.GetItemChecked(index));
        }

        void SaveMPAdvOptions(CheckedListBox game_options)
        {
            string mp_adv_options_str = "";

            mp_adv_options_str += "*Key = 0\r\n";
            mp_adv_options_str += "* Value = \"All\"\r\n";

            mp_adv_options_str += "*Key   = 1\r\n";
            mp_adv_options_str += "* Value = \"Teamplay <0>\"\r\n"; // This one will statically be set to 0 until team play is supported.

            mp_adv_options_str += "*Key = 2\r\n";
            mp_adv_options_str += "*Value = \"Friendly Fire < 0 >\"\r\n"; // Same as team play.

            mp_adv_options_str += "*Key = 3\r\n";
            mp_adv_options_str += "*Value = \"Rage <"+ GetCheckedOption(game_options, 0) +">\"\r\n";

            mp_adv_options_str += "*Key = 4\r\n";
            mp_adv_options_str += "* Value = \"Full Weapons <0>\"\r\n"; // statically coded to stay off, arsenal is controlled via other options.

            mp_adv_options_str += "*Key   = 5\r\n";
            mp_adv_options_str += "* Value = \"Auto Balance <0>\"\r\n"; // will probably stay off, see team play.

            mp_adv_options_str += "*Key   = 6\r\n";
            mp_adv_options_str += "* Value = \"Radar <"+ GetCheckedOption(game_options, 1) +">\"\r\n";

            mp_adv_options_str += "*Key   = 7\r\n";
            mp_adv_options_str += "* Value = \"Head Shots Only <"+GetCheckedOption(game_options, 2)+">\"\r\n";

            mp_adv_options_str += "*Key   = 8\r\n";
            mp_adv_options_str += "* Value = \"Weapons Stay <"+ GetCheckedOption(game_options, 3) +">\"\r\n";

            mp_adv_options_str += "*Key   = 9\r\n";
            mp_adv_options_str += "* Value = \"No Health <"+ GetCheckedOption(game_options, 4) +">\"\r\n";

            mp_adv_options_str += "*Key   = 10\r\n";
            mp_adv_options_str += "* Value = \"No Powerups <"+ GetCheckedOption(game_options, 5) + ">\"\r\n";

            mp_adv_options_str += "*Key   = 11\r\n";
            mp_adv_options_str += "* Value = \"One Shot Kill <"+ GetCheckedOption(game_options, 6) + ">\"\r\n";

            mp_adv_options_str += "*Key   = 12\r\n";
            mp_adv_options_str += "* Value = \"Unlimited Ammo <"+ GetCheckedOption(game_options, 7) + ">\"\r\n";

            byte[] mp_adv_option = new UTF8Encoding(true).GetBytes(mp_adv_options_str);
            mp_advoptions.Write(mp_adv_option, 0, mp_adv_option.Length);
            mp_advoptions.Close();

        }

        void SaveMPArsenal(CheckedListBox WeaponAvail,CheckedListBox WeaponSpawn)
        {

            /*
             * Crossbow 0
                Spider mine 1
                Spider Mine 2
                Pistol 3
                Shotgun 4
                Minigun 5
                Rocket Launcher 6
                Tek Weapon 7
                Flamethrower 8
                Gravity Distruptor 9
                Dark Matter Cube 10
           */

            string mp_arsenal_str = "";
            mp_arsenal_str += "*Key   = 0\r\n";
            mp_arsenal_str += "* Value = \"All\"\r\n";

            mp_arsenal_str += "*Key = 1\r\n";
            mp_arsenal_str += "* Value = \"crossbow available <" + GetCheckedOption(WeaponAvail,0) + ">\"\r\n";

            mp_arsenal_str += "*Key = 2\r\n";
            mp_arsenal_str += "* Value = \"spike mine available <" + GetCheckedOption(WeaponAvail, 1) + ">\"\r\n";

            mp_arsenal_str += "* Key = 3\r\n";
            mp_arsenal_str += "* Value = \"sniper pistol available <" + GetCheckedOption(WeaponAvail, 3) + ">\"\r\n";

            mp_arsenal_str += "* Key = 4\r\n";
            mp_arsenal_str += "* Value = \"shotgun available <" + GetCheckedOption(WeaponAvail, 4) + ">\"\r\n";

            mp_arsenal_str += "* Key = 5\r\n";
            mp_arsenal_str += "* Value = \"minigun available <" + GetCheckedOption(WeaponAvail, 5) + ">\"\r\n";

            mp_arsenal_str += "* Key = 6\r\n";
            mp_arsenal_str += "* Value = \"launcher available <" + GetCheckedOption(WeaponAvail, 6) + ">\"\r\n";

            mp_arsenal_str += "* Key = 7\r\n";
            mp_arsenal_str += "* Value = \"tek weapon available <" + GetCheckedOption(WeaponAvail, 7) + ">\"\r\n";

            mp_arsenal_str += "* Key = 8\r\n";
            mp_arsenal_str += "* Value = \"flamethrower available <" + GetCheckedOption(WeaponAvail, 8) + ">\"\r\n";

            mp_arsenal_str += "* Key = 9\r\b";
            mp_arsenal_str += "* Value = \"remote device available <" + GetCheckedOption(WeaponAvail, 2) + ">\"\r\n";

            mp_arsenal_str += "* Key = 10\r\n";
            mp_arsenal_str += "* Value = \"gravity disruptor available <" + GetCheckedOption(WeaponAvail, 9) + ">\"\r\n";

            mp_arsenal_str += "* Key = 11\r\n";
            mp_arsenal_str += "* Value = \"dark matter cube available <" + GetCheckedOption(WeaponAvail, 10) + ">\"\r\n";

            mp_arsenal_str += "*Key = 12\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 13\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 14\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 15\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 16\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 17\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 18\r\n";
            mp_arsenal_str += "* Value = \"crossbow spawn <" + GetCheckedOption(WeaponSpawn, 0) + ">\"\r\n";

            mp_arsenal_str += "* Key = 19\r\n";
            mp_arsenal_str += "* Value = \"spike mine spawn <" + GetCheckedOption(WeaponSpawn, 1) + ">\"\r\n";

            mp_arsenal_str += "* Key = 20\r\n";
            mp_arsenal_str += "* Value = \"sniper pistol spawn <" + GetCheckedOption(WeaponSpawn, 3) + ">\"\r\n";

            mp_arsenal_str += "* Key = 21\r\n";
            mp_arsenal_str += "* Value = \"shotgun spawn <" + GetCheckedOption(WeaponSpawn, 4) + ">\"\r\n";

            mp_arsenal_str += "* Key = 22\r\n";
            mp_arsenal_str += "* Value = \"minigun spawn <" + GetCheckedOption(WeaponSpawn, 5) + ">\"\r\n";

            mp_arsenal_str += "* Key = 23\r\n";
            mp_arsenal_str += "* Value = \"launcher spawn <" + GetCheckedOption(WeaponSpawn, 6) + ">\"\r\n";

            mp_arsenal_str += "* Key = 24\r\n";
            mp_arsenal_str += "* Value = \"tek weapon spawn <" + GetCheckedOption(WeaponSpawn, 7) + ">\"\r\n";

            mp_arsenal_str += "* Key = 25\r\n";
            mp_arsenal_str += "* Value = \"flamethrower spawn <" + GetCheckedOption(WeaponSpawn, 8) + ">\"\r\n";

            mp_arsenal_str += "* Key = 26\r\n";
            mp_arsenal_str += "* Value = \"remote device spawn <" + GetCheckedOption(WeaponSpawn, 2) + ">\"\r\n";

            mp_arsenal_str += "* Key = 27\r\n";
            mp_arsenal_str += "* Value = \"gravity disruptor spawn <" + GetCheckedOption(WeaponSpawn, 9) + ">\"\r\n";

            mp_arsenal_str += "* Key = 28\r\n";
            mp_arsenal_str += "* Value = \"dark matter cube spawn <" + GetCheckedOption(WeaponSpawn, 10) + ">\"\r\n";

            mp_arsenal_str += "* Key = 29\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 30\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 31\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 32\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 33\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            mp_arsenal_str += "* Key = 34\r\n";
            mp_arsenal_str += "* Value = \"available <0>\"\r\n";

            byte[] mp_arsenal_option = new UTF8Encoding(true).GetBytes(mp_arsenal_str);
            mp_arsenal.Write(mp_arsenal_option, 0, mp_arsenal_option.Length);
            mp_arsenal.Close();


        }

        void SaveMPHist()
        {
            string mp_hist_string = "";

            mp_hist_string += "*Key = 0\r\n";
            mp_hist_string += "*Value = \"All\"\r\n";
            mp_hist_string += "\r\n";

            /*
                *Value = "Game Type <0>"
                *Comment = "0 - Team Deathmatch"
                *Comment = "1 - Predator"
                *Comment = "2 - Classic CTF"
                *Comment = "3 - One Flag CTF"
                *Comment = "4 - Last Man"
                *Comment = "5 - Co-Op"
                *Comment = "6 - Bag Tag"
                *Comment = "7 - Flight"
            */
            mp_hist_string += "*Key = 1\r\n";
            mp_hist_string += "*Value = \"Game Type <"+game_type+">\"\r\n";
            mp_hist_string += "\r\n";

            mp_hist_string += "*Key = 2\r\n";
            mp_hist_string += "*Value = \"Map <"+map_id+">\"\r\n";
            mp_hist_string += "\r\n";

            mp_hist_string += "*Key = 3\r\n";
            mp_hist_string += "*Value = \"frag limit <"+frag_limit+">\"\r\n";
            mp_hist_string += "\r\n";

            mp_hist_string += "*Key = 4\r\n";
            mp_hist_string += "*Value = \"time limit <"+time_limit+">\"\r\n";
            mp_hist_string += "\r\n";

            mp_hist_string += "*Key = 5\r\n";
            mp_hist_string += "*Value = \"bots<0>\" \r\n";
            mp_hist_string += "\r\n";

            mp_hist_string += "*Key = 6\r\n";
            mp_hist_string += "*Value = \"was flight<0>\" \r\n";
            mp_hist_string += "\r\n";

            byte[] mp_hist_bytes = new UTF8Encoding(true).GetBytes(mp_hist_string);

            mp_hist.Write(mp_hist_bytes, 0, mp_hist_bytes.Length);
            mp_hist.Close();
        }

        public void Save(CheckedListBox game_options, CheckedListBox weapons_avail, CheckedListBox weapons_spawn)
        {
            SaveMPHist();
            SaveMPAdvOptions(game_options);
            SaveMPArsenal(weapons_avail, weapons_spawn);

        }
    }
}
