namespace Parsys
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SplashScreenProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleLabel.Location = new System.Drawing.Point(315, 289);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(264, 36);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "نرم افزار انبارداری پارسیس";
            // 
            // SplashScreenProgressBar
            // 
            this.SplashScreenProgressBar.BackColor = System.Drawing.Color.Black;
            this.SplashScreenProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SplashScreenProgressBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SplashScreenProgressBar.Location = new System.Drawing.Point(0, 347);
            this.SplashScreenProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SplashScreenProgressBar.Name = "SplashScreenProgressBar";
            this.SplashScreenProgressBar.RightToLeftLayout = true;
            this.SplashScreenProgressBar.Size = new System.Drawing.Size(600, 19);
            this.SplashScreenProgressBar.Step = 500;
            this.SplashScreenProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SplashScreenProgressBar.TabIndex = 1;
            this.SplashScreenProgressBar.Value = 100;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressLabel.Font = new System.Drawing.Font("B Yekan", 7F);
            this.ProgressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressLabel.Location = new System.Drawing.Point(29, 325);
            this.ProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(547, 20);
            this.ProgressLabel.TabIndex = 0;
            this.ProgressLabel.Text = "در حال بارگزاری سیستم";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parsys.Properties.Resources.keyboard_15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SplashScreenProgressBar);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreenForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ProgressBar SplashScreenProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
    }
}

