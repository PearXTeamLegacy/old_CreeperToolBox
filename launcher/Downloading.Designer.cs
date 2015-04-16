namespace launcher
{
    partial class Downloading
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
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.StepText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DownloadBar
            // 
            this.DownloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadBar.Location = new System.Drawing.Point(12, 43);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(455, 33);
            this.DownloadBar.TabIndex = 0;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // StepText
            // 
            this.StepText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepText.AutoSize = true;
            this.StepText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepText.Location = new System.Drawing.Point(12, 9);
            this.StepText.Name = "StepText";
            this.StepText.Size = new System.Drawing.Size(316, 25);
            this.StepText.TabIndex = 1;
            this.StepText.Text = "Шаг 1/7: Скачивание ресурсов";
            // 
            // Downloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 88);
            this.Controls.Add(this.StepText);
            this.Controls.Add(this.DownloadBar);
            this.Icon = global::launcher.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "Downloading";
            this.Text = "Загрузка игры...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Downloading_FormClosing);
            this.Load += new System.EventHandler(this.Downloading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar DownloadBar;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label StepText;
    }
}