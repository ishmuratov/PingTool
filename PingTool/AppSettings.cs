using PingTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTool
{
    [Serializable]
    public class AppSettings : IData
    {
        public int PING_REFRESH_TIME = 5000;   // 5 sec

        // Mail settings

        public bool MAIL_DISABLED = false;
        public string MAIL_FROM = "";
        public string MAIL_PASSWORD_FROM = "";
        public string MAIL_TO = "";

        // Mail Server settings

        public string MAIL_SERVER_HOST = "smtp.gmail.com";
        public int MAIL_SERVER_PORT = 587;
        public string MAIL_SENDER_NAME = "Zabbix";
    }
}
