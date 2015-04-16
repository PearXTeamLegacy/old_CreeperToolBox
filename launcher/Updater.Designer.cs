namespace launcher
{
    partial class Updater
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
            this.components = new System.ComponentModel.Container();
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            this.Timer_Updater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DownloadBar
            // 
            this.DownloadBar.Location = new System.Drawing.Point(12, 12);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(522, 37);
            this.DownloadBar.TabIndex = 0;
            // 
            // Timer_Updater
            // 
            this.Timer_Updater.Enabled = true;
            this.Timer_Updater.Interval = 1;
            this.Timer_Updater.Tick += new System.EventHandler(this.Timer_Updater_Tick);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 63);
            this.Controls.Add(this.DownloadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Updater";
            this.ShowInTaskbar = false;
            this.Text = "Обновление Creeper ToolBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.Load += new System.EventHandler(this.Updater_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar DownloadBar;
        private System.Windows.Forms.Timer Timer_Updater;
    }
}