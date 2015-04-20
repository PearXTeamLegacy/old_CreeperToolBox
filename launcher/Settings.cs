using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace launcher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void ChangeWallpaperBtn_Click(object sender, EventArgs e)
        {
            if (WallpaperDialog.ShowDialog() == DialogResult.OK)
            {
                Launcher.WallpaperPath = WallpaperDialog.FileName;
                MessageBox.Show("Перезапустите программу", "Обои изменены!");
            }
        }

        private void ResetWallpaperBtn_Click(object sender, EventArgs e)
        {
            Launcher.WallpaperPath = null;
            MessageBox.Show("Перезапустите программу", "Обои изменены!");
        }

        private void MemoryBar_Scroll(object sender, EventArgs e)
        {
            if (MemoryBar.Value == 0)
            {
                Launcher.Memory = 512;
            }
            else if (MemoryBar.Value == 1)
            {
                Launcher.Memory = 1024;
            }
            else if (MemoryBar.Value == 2)
            {
                Launcher.Memory = 1536;
            }
            else if (MemoryBar.Value == 3)
            {
                Launcher.Memory = 2048;
            }
            else if (MemoryBar.Value == 4)
            {
                Launcher.Memory = 2560;
            }
            else if (MemoryBar.Value == 5)
            {
                Launcher.Memory = 3072;
            }
            else if (MemoryBar.Value == 6)
            {
                Launcher.Memory = 3584;
            }
            else if (MemoryBar.Value == 7)
            {
                Launcher.Memory = 4096;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Launcher.FullScreen == true) FullScreenBox.Checked = true;
            if (Launcher.Memory == 512)
            {
                MemoryBar.Value = 0;
            }
            else if (Launcher.Memory == 1024)
            {
                MemoryBar.Value = 1;
            }
            else if (Launcher.Memory == 1536)
            {
                MemoryBar.Value = 2;
            }
            else if (Launcher.Memory == 2048)
            {
                MemoryBar.Value = 3;
            }
            else if (Launcher.Memory == 2560)
            {
                MemoryBar.Value = 4;
            }
            else if (Launcher.Memory == 3072)
            {
                MemoryBar.Value = 5;
            }
            else if (Launcher.Memory == 3584)
            {
                MemoryBar.Value = 6;
            }
            else if (Launcher.Memory == 4096)
            {
                MemoryBar.Value = 7;
            }
            label9.Text = "Версия ресурсов - " + versions.assetsv + "\nВерсия ядра игры - " + versions.gamev + "\nВерсия библиотек - " + versions.libsv + "\nВерсия MinecraftForge - " + versions.forgev + "\nВыпуск прочих файлов - " + versions.otherv;
        }

        private void FullScreenBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FullScreenBox.Checked == true)
            {
                Launcher.FullScreen = true;
            }
            else
            {
                Launcher.FullScreen = false;
            }
        }
    }
}
