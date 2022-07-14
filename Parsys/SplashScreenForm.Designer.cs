﻿namespace Parsys
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SplashScreenProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(153, 294);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(332, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "نرم افزار انبارداری پارسیس";
            // 
            // SplashScreenProgressBar
            // 
            this.SplashScreenProgressBar.BackColor = System.Drawing.Color.Black;
            this.SplashScreenProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SplashScreenProgressBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SplashScreenProgressBar.Location = new System.Drawing.Point(0, 413);
            this.SplashScreenProgressBar.Name = "SplashScreenProgressBar";
            this.SplashScreenProgressBar.RightToLeftLayout = true;
            this.SplashScreenProgressBar.Size = new System.Drawing.Size(638, 23);
            this.SplashScreenProgressBar.Step = 50;
            this.SplashScreenProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SplashScreenProgressBar.TabIndex = 1;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressLabel.Font = new System.Drawing.Font("B Yekan", 8F);
            this.ProgressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressLabel.Location = new System.Drawing.Point(12, 386);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(614, 24);
            this.ProgressLabel.TabIndex = 0;
            this.ProgressLabel.Text = "در حال بارگزاری سیستم";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parsys.Properties.Resources.rising_sun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 436);
            this.Controls.Add(this.SplashScreenProgressBar);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreenForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ProgressBar SplashScreenProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
    }
}

