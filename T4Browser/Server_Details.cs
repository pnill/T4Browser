using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Browser
{

    public class Server_Details
    {
        public string server_name { get; set; }
        public int player_count { get; set; }
        public int max_players { get; set; }
        public string map_name { get; set; }
        public int port { get; set; }
        public string ip_address { get; set; }
        public string game_type { get; set; }
    }
}
