using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher
{
    public partial class Launcher : Form
    {
        public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string foldername = ".CTB";
        public static string WallpaperPath;
        public static string LauncherDataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PearX\\CTB";
        public static string NickName = "Player";
        public static int Memory = 1024;
        public static bool FullScreen = false;
        bool GameChecked;


        public Launcher()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings f = new Settings();
            f.ShowDialog();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            CheckLibs();
            try
            {
                WebClient ads = new WebClient();
                LauncherAds.Text = ads.DownloadString("http://pearx.ru/ctb/adtext");
            }
            catch { }
            if (!Directory.Exists(LauncherDataPath)) Directory.CreateDirectory(LauncherDataPath);
            if (!Directory.Exists(appdata + "\\" + foldername)) Directory.CreateDirectory(appdata + "\\" + foldername);
            if (!Directory.Exists(appdata + "\\" + foldername + "\\bin")) Directory.CreateDirectory(appdata + "\\" + foldername + "\\bin");
            try
            {
                string[] s1;
                s1 = File.ReadAllLines(LauncherDataPath + "\\properties");
                WallpaperPath = s1[0];
                NickName = s1[1];
                Memory = Convert.ToInt32(s1[2]);
                FullScreen = Convert.ToBoolean(s1[3]);
            }
            catch { }
            if (File.Exists(LauncherDataPath + "\\version"))
            {
                string[] s1;
                s1 = File.ReadAllLines(LauncherDataPath + "\\versions");
                versions.assetsv = s1[0];
                versions.libsv = s1[1];
                versions.forgev = s1[2];
                versions.gamev = s1[3];
                versions.otherv = s1[4];
            }
            UserNameBox.Text = NickName;
            
            if (File.Exists(WallpaperPath))
            {
                this.BackgroundImage = Image.FromFile(WallpaperPath);
            }
            CheckGame();
            

        }

        private void Launcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines(LauncherDataPath + "\\properties", new string[] { 
                WallpaperPath,
                NickName,
                Memory.ToString(),
                FullScreen.ToString()
            });
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
            NickName = UserNameBox.Text;
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            if (NickName != null && NickName != "" && GameChecked == true)
            {
                LaunchGame lg = new LaunchGame();
                lg.StartGame();
            }
            else
            {
                Downloading d = new Downloading();
                d.Show();
            }
        }

        private void OpenGameFolder_Click(object sender, EventArgs e)
        {
            Process.Start(appdata + "\\" + foldername);
        }

        public void CheckGame()
        {
            string pathtogame = appdata + "\\" + foldername + "\\";
            if (
                File.Exists(pathtogame + "bin\\game.jar") &&
                Directory.Exists(pathtogame + "assets") &&
                File.Exists(pathtogame + "bin\\forge.jar") &&
                File.Exists(pathtogame + "bin\\libs.jar") &&
                Directory.Exists(pathtogame + "bin\\natives")
                ) GameChecked = true;
            else GameChecked = false;
        }

        private void ClearDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Все Ваши модификации, карты, ресурспаки \n и прочее БУДЕТ БЕЗВОЗВРАТНО УДАЛЕНО! \n Вы действительно хотите это сделать?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(appdata + "\\" + foldername, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Произошла ошибка");
                }
            if (!Directory.Exists(appdata + "\\" + foldername)) Directory.CreateDirectory(appdata + "\\" + foldername);
            if (!Directory.Exists(appdata + "\\" + foldername + "\\bin")) Directory.CreateDirectory(appdata + "\\" + foldername + "\\bin");
            }
        }

        private void LauncherAds_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient ads = new WebClient();
                Process.Start(ads.DownloadString("http://pearx.ru/ctb/adurl"));
            }
            catch { }
        }

        private void updt_Tick(object sender, EventArgs e)
        {
            updt.Stop();
            WebClient updater = new WebClient();
            try
            {
                string actual = updater.DownloadString("http://pearx.ru/ctb/version");
                if (actual != versions.v)
                {
                    DialogResult result = MessageBox.Show("Обновить?", "Доступно обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Updater f2 = new Updater();
                        f2.ShowDialog();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Невозможно проверить обновления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CheckLibs()
        {
            WebClient client = new WebClient();
            if (!File.Exists("Ionic.Zip.dll"))
            {
                try
                {
                    MessageBox.Show("Невозможно найти библиотеки Creeper ToolBox!\nБиблиотеки будут сейчас скачаны", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    client.DownloadFile("http://pearx.ru/ctb/Ionic.Zip.dll", "Ionic.Zip.dll");
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить библиотеки Creeper ToolBox!\nПриложение будет закрыто!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            if (!File.Exists("updater.exe"))
            {
                try
                {
                    MessageBox.Show("Невозможно найти компонент обновления!\nОн будет сейчас скачан", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    client.DownloadFile("http://pearx.ru/ctb/updater.exe", "updater.exe");
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить компонент обновления!\nПриложение будет закрыто!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
