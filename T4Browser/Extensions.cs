using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace T4Browser
{
    static class SocketExtensions
    {
        public static bool IsConnected(this Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException) { return false; }
        }
    }

    public static class Extensions
    {
        public static void Invoke(this Control control, Action action, bool async = false)
        {
            if (async)
                control.BeginInvoke(action);
            else if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }
    }
}
