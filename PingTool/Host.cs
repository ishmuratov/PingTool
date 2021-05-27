using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTool
{
    [Serializable]
    public class Host
    {
        public string IP { get; set; }
        public string Name { get; set; }
        public string Comment { get; }
        public int OfflineCounter { get; set; }
        public bool FailMailSended { get; set; }
        public bool OKMailNeed { get; set; }

        public Host(string _ip, string _name, string _comment = "")
        {
            IP = _ip;
            Name = _name;
            Comment = _comment;
            OfflineCounter = 0;
            FailMailSended = false;
        }

    }
}
