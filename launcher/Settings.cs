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
            Launcher.Memory = (MemoryBar.Value + 1) * 512;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Launcher.FullScreen == true) FullScreenBox.Checked = true;
            MemoryBar.Value = (Launcher.Memory - 512) / 512;
            label9.Text = "Версия ресурсов - " + versions.assetsv + "\nВерсия ядра игры - " + versions.gamev + "\nВерсия библиотек - " + versions.libsv + "\nВерсия MinecraftForge - " + versions.forgev + "\nВыпуск прочих файлов - " + versions.otherv;
            label12.Text = "Creeper ToolBox " + versions.v;
            if (Launcher.ownStartString == true)
            {
                ownStartStringBox.Checked = true;
                ownStartBox.Enabled = true;
            }
            ownStartBox.Text = Launcher.ownString;
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

        private void ownStartStringBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ownStartStringBox_Click(object sender, EventArgs e)
        {
            if (ownStartStringBox.Checked == true)
            {
                DialogResult result = MessageBox.Show("Используйте это только тогда, когда вы знаете, что делаете!", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    ownStartStringBox.Checked = false;
                }
                else
                {
                    ownStartBox.Enabled = true;
                    Launcher.ownStartString = true;
                }
            }
            else
            {
                ownStartBox.Enabled = false;
                Launcher.ownStartString = false;
            }
        }

        private void ownStartBox_TextChanged(object sender, EventArgs e)
        {
            Launcher.ownString = ownStartBox.Text;
        }
    }
}
