using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTool
{
    public partial class AddHost : Form
    {
        Host newHost;

        public AddHost()
        {
            InitializeComponent();
        }

        public Host NewHost
        {
            get { return newHost; }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            newHost = new Host(tbNewHostAdd.Text, tbNewHostName.Text);
            Close();
        }
    }
}
