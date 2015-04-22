using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace launcher
{
    public partial class Downloading : Form
    {
        WebClient client = new WebClient();
        int step = 0;
        public int type;
        public Downloading()
        {
            InitializeComponent();
        }

        private void Downloading_Load(object sender, EventArgs e)
        {
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (type == 1)
            {
                if (step == 0)
                {
                    step++;
                    DownloadBar.Visible = false;
                    StepText.Text = "Шаг 2/7: Распаковка ресурсов...";
                    StepText.Location = new Point(69, 27);
                    Thread thr = new Thread(ExtractZip);
                    thr.Start();
                    thr.Join();
                    StepText.Location = new Point(12, 9);
                    File.Delete(Launcher.LauncherDataPath + "\\assets.zip");
                    StepText.Text = "Шаг 3/7: Скачивание ядра игры";
                    DownloadBar.Visible = true;
                    client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/client/game.jar"), Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\game.jar");
                }
                else if (step == 1)
                {
                    step++;
                    StepText.Text = "Шаг 4/7: Скачивание MinecraftForge";
                    DownloadBar.Visible = true;
                    client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/client/forge.jar"), Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar");
                }
                else if (step == 2)
                {
                    step++;
                    StepText.Text = "Шаг 5/7: Скачивание библиотек игры";
                    DownloadBar.Visible = true;
                    client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/client/libs.jar"), Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\libs.jar");
                }
                else if (step == 3)
                {
                    step++;
                    StepText.Text = "Шаг 6/7: Скачивание дополнительных файлов";
                    DownloadBar.Visible = true;
                    client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/client/other.zip"), Launcher.LauncherDataPath + "\\other.zip");
                }
                else if (step == 4)
                {
                    DownloadBar.Visible = false;
                    StepText.Text = "Шаг 7/7: Распаковка дополнительных файлов...";
                    StepText.Location = new Point(8, 27);
                    Thread thr = new Thread(ExtractZip);
                    thr.Start();
                    thr.Join();
                    StepText.Location = new Point(12, 9);
                    File.Delete(Launcher.LauncherDataPath + "\\other.zip");
                    versions.assetsv = client.DownloadString("http://pearx.ru/ctb/client/assets.v");
                    versions.libsv = client.DownloadString("http://pearx.ru/ctb/client/libs.v");
                    versions.forgev = client.DownloadString("http://pearx.ru/ctb/client/forge.v");
                    versions.gamev = client.DownloadString("http://pearx.ru/ctb/client/game.v");
                    versions.otherv = client.DownloadString("http://pearx.ru/ctb/client/other.v");
                    StepText.Text = "Готово";
                    this.Close();
                    Program.l.CheckGame();
                }
            }
            else if(type == 2)
            {
                versions.forgev = client.DownloadString("http://pearx.ru/ctb/client/forge.v");
                StepText.Text = "Готово";
                this.Close();
                Program.l.CheckGame();
                type = 1;
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Maximum = (int)e.TotalBytesToReceive / 100;
            DownloadBar.Value = (int)e.BytesReceived / 100;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (type == 1)
            {
                if (File.Exists(Launcher.LauncherDataPath + "\\assets.zip")) File.Delete(Launcher.LauncherDataPath + "\\assets.zip");
                if (File.Exists(Launcher.LauncherDataPath + "\\other.zip")) File.Delete(Launcher.LauncherDataPath + "\\other.zip");
                if (File.Exists(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\game.jar")) File.Delete(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\game.jar");
                if (File.Exists(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\libs.jar")) File.Delete(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\libs.jar");
                if (File.Exists(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar")) File.Delete(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar");
                if (Directory.Exists(Launcher.appdata + "\\" + Launcher.foldername + "\\assets")) Directory.Delete(Launcher.appdata + "\\" + Launcher.foldername + "\\assets", true);
                if (Directory.Exists(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\natives")) Directory.Delete(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\natives", true);
                client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/client/assets.zip"), Launcher.LauncherDataPath + "\\assets.zip");
                UpdateTimer.Stop();
            }
            else if (type == 2)
            {
                UpdateTimer.Stop();
                if (File.Exists(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar")) File.Delete(Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar");
                StepText.Text = "Шаг 1/1: Обновление MinecraftForge";
                client.DownloadFileAsync(new Uri("http://pearx.ru/ctb/client/forge.jar"), Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar");
            }
        }

        private void Downloading_FormClosing(object sender, FormClosingEventArgs e)
        {
                
        }

        void ExtractZip()
        {
            if (step == 1)
            {
                using (ZipFile zip = ZipFile.Read(Launcher.LauncherDataPath + "\\assets.zip"))
                {
                    try
                    {
                        zip.ExtractAll(Launcher.appdata + "\\" + Launcher.foldername);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (step == 4)
            {
                using (ZipFile zip = ZipFile.Read(Launcher.LauncherDataPath + "\\other.zip"))
                {
                    try
                    {
                        zip.ExtractAll(Launcher.appdata + "\\" + Launcher.foldername);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
