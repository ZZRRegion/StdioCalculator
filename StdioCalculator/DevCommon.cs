using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdioCalculator
{
    public static class DevCommon
    {
        public static string Version => "1.0.0.0";
        public static string VersionTime => "2018-12-26 09:50:00";
        public static void MsgBox(this Control @this, string msg)
        {
            MessageBox.Show(@this, msg);
        }
    }
}
