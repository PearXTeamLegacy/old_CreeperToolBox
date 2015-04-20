namespace launcher
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeWallpaperBtn = new System.Windows.Forms.Button();
            this.WallpaperDialog = new System.Windows.Forms.OpenFileDialog();
            this.ResetWallpaperBtn = new System.Windows.Forms.Button();
            this.MemoryBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FullScreenBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeWallpaperBtn
            // 
            this.ChangeWallpaperBtn.Location = new System.Drawing.Point(12, 12);
            this.ChangeWallpaperBtn.Name = "ChangeWallpaperBtn";
            this.ChangeWallpaperBtn.Size = new System.Drawing.Size(112, 40);
            this.ChangeWallpaperBtn.TabIndex = 0;
            this.ChangeWallpaperBtn.Text = "Сменить обои";
            this.ChangeWallpaperBtn.UseVisualStyleBackColor = true;
            this.ChangeWallpaperBtn.Click += new System.EventHandler(this.ChangeWallpaperBtn_Click);
            // 
            // WallpaperDialog
            // 
            this.WallpaperDialog.Filter = "Картинки|*.jpg;*.png;*.gif;*.bmp;*.jpeg";
            // 
            // ResetWallpaperBtn
            // 
            this.ResetWallpaperBtn.Location = new System.Drawing.Point(130, 12);
            this.ResetWallpaperBtn.Name = "ResetWallpaperBtn";
            this.ResetWallpaperBtn.Size = new System.Drawing.Size(62, 27);
            this.ResetWallpaperBtn.TabIndex = 1;
            this.ResetWallpaperBtn.Text = "Сброс";
            this.ResetWallpaperBtn.UseVisualStyleBackColor = true;
            this.ResetWallpaperBtn.Click += new System.EventHandler(this.ResetWallpaperBtn_Click);
            // 
            // MemoryBar
            // 
            this.MemoryBar.Location = new System.Drawing.Point(12, 98);
            this.MemoryBar.Maximum = 7;
            this.MemoryBar.Name = "MemoryBar";
            this.MemoryBar.Size = new System.Drawing.Size(432, 45);
            this.MemoryBar.TabIndex = 2;
            this.MemoryBar.Scroll += new System.EventHandler(this.MemoryBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "512";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "1536";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "2048";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "2560";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "3072";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "3584";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "4096";
            // 
            // FullScreenBox
            // 
            this.FullScreenBox.AutoSize = true;
            this.FullScreenBox.BackColor = System.Drawing.SystemColors.Control;
            this.FullScreenBox.Location = new System.Drawing.Point(12, 149);
            this.FullScreenBox.Name = "FullScreenBox";
            this.FullScreenBox.Size = new System.Drawing.Size(145, 17);
            this.FullScreenBox.TabIndex = 11;
            this.FullScreenBox.Text = "Запуск в полный экран";
            this.FullScreenBox.UseVisualStyleBackColor = false;
            this.FullScreenBox.CheckedChanged += new System.EventHandler(this.FullScreenBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 65);
            this.label9.TabIndex = 12;
            this.label9.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 291);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FullScreenBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemoryBar);
            this.Controls.Add(this.ResetWallpaperBtn);
            this.Controls.Add(this.ChangeWallpaperBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::launcher.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemoryBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeWallpaperBtn;
        private System.Windows.Forms.OpenFileDialog WallpaperDialog;
        private System.Windows.Forms.Button ResetWallpaperBtn;
        private System.Windows.Forms.TrackBar MemoryBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox FullScreenBox;
        private System.Windows.Forms.Label label9;
    }
}