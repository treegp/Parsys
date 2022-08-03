namespace Parsys.WinClient.Views.Framework
{
    partial class MainBaseForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseCurrentTabButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(863, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 576);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(863, 22);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainTabPage
            // 
            this.MainTabPage.Location = new System.Drawing.Point(4, 23);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(855, 525);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "صفحه اصلی";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.RightToLeftLayout = true;
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(863, 552);
            this.MainTabControl.TabIndex = 2;
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Interval = 1000;
            // 
            // CloseCurrentTabButton
            // 
            this.CloseCurrentTabButton.BackColor = System.Drawing.Color.SandyBrown;
            this.CloseCurrentTabButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CloseCurrentTabButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseCurrentTabButton.Location = new System.Drawing.Point(12, 1);
            this.CloseCurrentTabButton.Name = "CloseCurrentTabButton";
            this.CloseCurrentTabButton.Size = new System.Drawing.Size(23, 23);
            this.CloseCurrentTabButton.TabIndex = 0;
            this.CloseCurrentTabButton.Tag = "بستن تب جاری";
            this.CloseCurrentTabButton.Text = "X";
            this.CloseCurrentTabButton.UseVisualStyleBackColor = false;
            this.CloseCurrentTabButton.Click += new System.EventHandler(this.CloseCurrentTabButton_Click);
            // 
            // MainBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 598);
            this.Controls.Add(this.CloseCurrentTabButton);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainBaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پارسیس";
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.Button CloseCurrentTabButton;
    }
}