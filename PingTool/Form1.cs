using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PingTool
{
    public partial class Form1 : Form
    {
        Hosts hosts = (Hosts)FileWorker.LoadFromFile("hosts.txt");
        AppSettings globalSettings = (AppSettings)FileWorker.LoadFromFile("settings.ini");
        System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();
        }

        // Start window

        private void Form1_Load(object sender, EventArgs e)
        {
            if (hosts == null)
            {
                hosts = new Hosts();
            }

            if (globalSettings == null)
            {
                globalSettings = new AppSettings();
                FileWorker.SaveToFile(globalSettings, "settings.ini");
            }
            
            // setup grid settings
            GridViewSettings.Setup(MainDataGridView, Color.Green);
            if (hosts.HostsList.Count != 0)
            {
                GridViewSettings.ViewNotes(MainDataGridView, hosts.HostsList, globalSettings);
            }
            SetTimer();
        }

        // View Data

        private void PingTimer_Tick(object sender, EventArgs e)
        {
            if (hosts.HostsList.Count != 0)
            {
                GridViewSettings.ViewNotes(MainDataGridView, hosts.HostsList, globalSettings);
            }
            if (Logger.LogChanged)
            {
                Logger.SaveLog();
            }
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(globalSettings.PING_REFRESH_TIME);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, EventArgs e)
        {
            for(int i = 0; i < hosts.HostsList.Count; i++)
            {
                if (!Pinger.PingHost(hosts.HostsList[i].IP))
                {
                    ++hosts.HostsList[i].OfflineCounter;
                }
                else
                {
                    hosts.HostsList[i].OfflineCounter = 0;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aTimer.Stop();
            aTimer.Dispose();
        }

        private void btAddHost_Click(object sender, EventArgs e)
        {
            AddHost addHost = new AddHost();
            addHost.ShowDialog();
            if (addHost.NewHost != null)
            {
                hosts.HostsList.Add(addHost.NewHost);
                GridViewSettings.ViewNotes(MainDataGridView, hosts.HostsList, globalSettings);
                FileWorker.SaveToFile(hosts, "hosts.txt");
            }
        }

        private void btDeleteHost_Click(object sender, EventArgs e)
        {
            if (MainDataGridView.SelectedRows.Count > 0)
            {
                int index = MainDataGridView.SelectedRows[0].Index;
                Host hostForDeleting = new Host(MainDataGridView[0, index].Value.ToString(), MainDataGridView[1, index].Value.ToString());
                foreach (Host anyHost in hosts.HostsList)
                {
                    if (anyHost.IP.Equals(hostForDeleting.IP) && anyHost.Name.Equals(hostForDeleting.Name))
                    {
                        hostForDeleting = anyHost;
                    }
                }
                if (hostForDeleting != null)
                {
                    hosts.HostsList.Remove(hostForDeleting);
                    GridViewSettings.ViewNotes(MainDataGridView, hosts.HostsList, globalSettings);
                    FileWorker.SaveToFile(hosts, "hosts.txt");
                }
            }
            else
            {
                MessageBox.Show("Ни один из хостов не выбран!");
            }
        }

        private void btEditHost_Click(object sender, EventArgs e)
        {
            if (MainDataGridView.SelectedRows.Count > 0)
            {
                int index = MainDataGridView.SelectedRows[0].Index;
                Host hostForEditing = new Host(MainDataGridView[0, index].Value.ToString(), MainDataGridView[1, index].Value.ToString());
                foreach (Host anyHost in hosts.HostsList)
                {
                    if (anyHost.IP.Equals(hostForEditing.IP) && anyHost.Name.Equals(hostForEditing.Name))
                    {
                        hostForEditing = anyHost;
                    }
                }
                if (hostForEditing != null)
                {
                    // Preparing and showing dialog
                    AddHost editHost = new AddHost();
                    editHost.tbNewHostAdd.Text = hostForEditing.IP;
                    editHost.tbNewHostName.Text = hostForEditing.Name;
                    editHost.btAdd.Text = "Изменить";
                    editHost.ShowDialog();
                    // Save changes
                    if (editHost.NewHost != null)
                    {
                        hostForEditing.IP = editHost.NewHost.IP;
                        hostForEditing.Name = editHost.NewHost.Name;
                        GridViewSettings.ViewNotes(MainDataGridView, hosts.HostsList, globalSettings);
                        FileWorker.SaveToFile(hosts, "hosts.txt");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ни один из хостов не выбран!");
            }
        }

        private void btOpenLog_Click(object sender, EventArgs e)
        {
            if (!File.Exists("log.txt"))
            {
                MessageBox.Show("Log-файл пуст!");
            }
            else
                Process.Start("log.txt");
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(globalSettings);
            settingsForm.ShowDialog();
            globalSettings = (AppSettings)FileWorker.LoadFromFile("settings.ini");
        }
    }
}
