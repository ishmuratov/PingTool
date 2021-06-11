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
    public partial class SettingsForm : Form
    {
        public SettingsForm(AppSettings settings)
        {
            InitializeComponent();
            tbTimerDelay.Text = settings.PING_REFRESH_TIME.ToString();
            tbMailAddrFrom.Text = settings.MAIL_FROM;
            tbMailPassFrom.Text = settings.MAIL_PASSWORD_FROM;
            tbMailAddrTo.Text = settings.MAIL_TO;
            cbMailDisabled.Checked = settings.MAIL_DISABLED;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppSettings globalSettings = new AppSettings();
            int.TryParse(tbTimerDelay.Text, out int newDelay);
            globalSettings.PING_REFRESH_TIME = (newDelay != 0) ? newDelay : 5000;
            globalSettings.MAIL_FROM = tbMailAddrFrom.Text;
            globalSettings.MAIL_PASSWORD_FROM = tbMailPassFrom.Text;
            globalSettings.MAIL_TO = tbMailAddrTo.Text;
            globalSettings.MAIL_DISABLED = cbMailDisabled.Checked;
            FileWorker.SaveToFile(globalSettings, "settings.ini");
            Close();
        }
    }
}
