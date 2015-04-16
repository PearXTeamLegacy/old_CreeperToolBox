using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace launcher
{
    public partial class Updater : Form
    {
        public WebClient client = new WebClient();
        public Updater()
        {
            InitializeComponent();
        }

        private void Timer_Updater_Tick(object sender, EventArgs e)
        {
            Timer_Updater.Stop();
            client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/launcher.exe"), "new.launcher.exe");
        }

        private void Updater_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start("updater.exe");
            Environment.Exit(0);
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Maximum = (int)e.TotalBytesToReceive / 100;
            DownloadBar.Value = (int)e.BytesReceived / 100;
        }
    }
}
