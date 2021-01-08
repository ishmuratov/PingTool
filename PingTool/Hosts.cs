using PingTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTool
{
    [Serializable]
    class Hosts : IData
    {
        public List<Host> HostsList { get; set; }

        public Hosts()
        {
            HostsList = new List<Host>();
        }
    }
}
