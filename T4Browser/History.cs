using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace T4Browser
{
    class History
    {

        public int map_id = 1;
        public int game_type = 0;
        public string frag_limit = "15";
        public string time_limit = "0";
       // int was_flight = 0;

        public History()
        {
            mp_hist = File.Open("C:\\TUROK\\data\\history\\multiplayer.hst", FileMode.Create, FileAccess.ReadWrite,FileShare.Read);

        }

        FileStream mp_hist;

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

        public void Save()
        {
            SaveMPHist();

        }
    }
}
