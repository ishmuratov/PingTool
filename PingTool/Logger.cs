using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PingTool
{
    public static class Logger
    {
        static List<String> LogMsg = new List<string>();
        public static bool LogChanged;

        public static void Log(string _msg)
        {
            LogMsg.Add(_msg);
            LogChanged = true;
        }

        public static void IOLog(string _msg)
        {
            MessageBox.Show(_msg);
        }

        public static void SaveLog()
        {
            StringBuilder sb = new StringBuilder();
            if (LogMsg != null)
            {
                for(int i = 0; i < LogMsg.Count; i++)
                {
                    sb.Append(LogMsg[i]);
                    if (i < LogMsg.Count - 1)
                    sb.Append(Environment.NewLine);
                }
                FileWorker.WriteToFile(sb.ToString(), "log.txt");
                LogMsg.Clear();
                LogChanged = false;
            }
        }
    }
}
