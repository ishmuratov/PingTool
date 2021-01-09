using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTool
{
    static class AppSettings
    {
        public static int PING_REFRESH_TIME = 5000;   // 5 sec

        // Mail settings

        public static string MAIL_FROM = "";
        public static string MAIL_PASSWORD_FROM = "";
        public static string MAIL_TO = "";
    }
}
