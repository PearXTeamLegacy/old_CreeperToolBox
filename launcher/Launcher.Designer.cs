using System.Drawing;
namespace launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.OpenGameFolder = new System.Windows.Forms.Button();
            this.ClearDirBtn = new System.Windows.Forms.Button();
            this.LauncherAds = new System.Windows.Forms.Label();
            this.updt = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.openSiteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBtn.Image = global::launcher.Properties.Resources.settings;
            this.SettingsBtn.Location = new System.Drawing.Point(681, 12);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(50, 42);
            this.SettingsBtn.TabIndex = 0;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameBox.Location = new System.Drawing.Point(277, 132);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(199, 31);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.Text = "Player";
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.Location = new System.Drawing.Point(277, 169);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(199, 42);
            this.StartGameBtn.TabIndex = 2;
            this.StartGameBtn.Text = "Играть";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // OpenGameFolder
            // 
            this.OpenGameFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenGameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenGameFolder.Location = new System.Drawing.Point(277, 217);
            this.OpenGameFolder.Name = "OpenGameFolder";
            this.OpenGameFolder.Size = new System.Drawing.Size(199, 46);
            this.OpenGameFolder.TabIndex = 3;
            this.OpenGameFolder.Text = "Открыть папку с игрой";
            this.OpenGameFolder.UseVisualStyleBackColor = true;
            this.OpenGameFolder.Click += new System.EventHandler(this.OpenGameFolder_Click);
            // 
            // ClearDirBtn
            // 
            this.ClearDirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDirBtn.Location = new System.Drawing.Point(277, 269);
            this.ClearDirBtn.Name = "ClearDirBtn";
            this.ClearDirBtn.Size = new System.Drawing.Size(199, 42);
            this.ClearDirBtn.TabIndex = 4;
            this.ClearDirBtn.Text = "Очистить папку";
            this.ClearDirBtn.UseVisualStyleBackColor = true;
            this.ClearDirBtn.Click += new System.EventHandler(this.ClearDirBtn_Click);
            // 
            // LauncherAds
            // 
            this.LauncherAds.AutoSize = true;
            this.LauncherAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LauncherAds.Location = new System.Drawing.Point(12, 9);
            this.LauncherAds.Name = "LauncherAds";
            this.LauncherAds.Size = new System.Drawing.Size(59, 13);
            this.LauncherAds.TabIndex = 6;
            this.LauncherAds.Text = "РЕКЛАМА";
            this.LauncherAds.Click += new System.EventHandler(this.LauncherAds_Click);
            // 
            // updt
            // 
            this.updt.Enabled = true;
            this.updt.Interval = 1;
            this.updt.Tick += new System.EventHandler(this.updt_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "ВНИМАНИЕ!\r\nЭто Alpha-версия Creeper ToolBox. В этой версии могут быть баги. \r\nО в" +
    "сех найденных багах пишите на форум!\r\n(нажмите чтобы открыть)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openSiteBtn
            // 
            this.openSiteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSiteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openSiteBtn.Location = new System.Drawing.Point(277, 317);
            this.openSiteBtn.Name = "openSiteBtn";
            this.openSiteBtn.Size = new System.Drawing.Size(199, 42);
            this.openSiteBtn.TabIndex = 8;
            this.openSiteBtn.Text = "Сайт лаунчера";
            this.openSiteBtn.UseVisualStyleBackColor = true;
            this.openSiteBtn.Click += new System.EventHandler(this.openSiteBtn_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::launcher.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.openSiteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LauncherAds);
            this.Controls.Add(this.ClearDirBtn);
            this.Controls.Add(this.OpenGameFolder);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.SettingsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::launcher.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.Text = "Creeper ToolBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button OpenGameFolder;
        private System.Windows.Forms.Button ClearDirBtn;
        private System.Windows.Forms.Label LauncherAds;
        private System.Windows.Forms.Timer updt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openSiteBtn;
    }
}

