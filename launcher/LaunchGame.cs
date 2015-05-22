using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace launcher
{
    class LaunchGame
    {
        string login = Launcher.NickName, pathtogame, javapath;
        bool outStartInfo = false; //Копирует в буфер строку запуска, ТОЛЬКО ДЛЯ ОТЛАДКИ!
        public void StartGame()
        {
            pathtogame = Launcher.appdata + "\\" + Launcher.foldername + "\\";
            if (!Directory.Exists(pathtogame)) Directory.CreateDirectory(pathtogame);
            string options = Launcher.appdata + "\\" + Launcher.foldername + "\\options.txt";
            if (!File.Exists(options)) File.WriteAllText(options, "lang:ru_RU");
            launch();

        }
        void checkjava()
        {
            try
            {
                RegistryKey javaInstalled = Registry.LocalMachine.OpenSubKey("SOFTWARE\\JavaSoft\\Java Runtime Environment\\");

                if (javaInstalled != null)
                {
                    string version = javaInstalled.GetValue("CurrentVersion").ToString();

                    RegistryKey javaPath = Registry.LocalMachine.OpenSubKey("Software\\JavaSoft\\Java Runtime Environment\\" + version + "\\");

                    if (javaPath != null)
                    {
                        string javaFolder = javaPath.GetValue("JavaHome").ToString();

                        javapath = javaFolder + "\\bin\\javaw.exe";
                    }
                }
            }
            catch { }
        }
        public void launch()
        {
            checkjava();
            Process mc = new Process();
            StringBuilder sb = new StringBuilder();
            sb.Append("-Xincgc ");
            sb.Append("-Xmx" + Launcher.Memory + "M ");
            sb.Append("-Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true ");
            sb.Append("-Djava.library.path=\"" + Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\natives\"" + " -cp \"" + Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\libs.jar;" + Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\forge.jar;" + Launcher.appdata + "\\" + Launcher.foldername + "\\bin\\game.jar\" " + "net.minecraft.launchwrapper.Launch ");
            sb.Append("--username " + login + " ");
            if (Launcher.FullScreen == true)
            {
                sb.Append("--fullscreen true ");
            }
            sb.Append("--version 1.7.10 ");
            sb.Append("--gameDir \"" + Launcher.appdata + "\\" + Launcher.foldername + "\" ");
            sb.Append("--assetsDir \"" + Launcher.appdata + "\\" + Launcher.foldername + "\\assets\" ");
            sb.Append("--assetIndex game ");
            sb.Append("--uuid 123 ");
            sb.Append("--accessToken  123 ");
            sb.Append("--userProperties {} ");
            sb.Append("--userType legacy ");
            sb.Append("--tweakClass cpw.mods.fml.common.launcher.FMLTweaker ");


            ProcessStartInfo mcStartInfo = new ProcessStartInfo(javapath, sb.ToString());
            ProcessStartInfo ownmcStartInfo = new ProcessStartInfo(javapath, Launcher.ownString);
            if (Launcher.ownStartString == true)
            {
                mc.StartInfo = ownmcStartInfo;
            }
            else
            {
                mc.StartInfo = mcStartInfo;
            }
            Program.l.Hide();
            if (outStartInfo == true)
            {
                Clipboard.SetText(sb.ToString());
            }
            if (outStartInfo == true)
            {
                MessageBox.Show(javapath);
            }
            try
            {
                mc.Start();
                mc.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Java не найдена!\nСкачайте Java!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("http://www.java.com/ru/download/");
            }
            Program.l.Show();
           
        }
        
    }
}
