namespace Parsys.WinClient.Views.WelcomeForms
{
    partial class ConnectionHandlerForm
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.IgnoreButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UserIdCheckBox = new System.Windows.Forms.CheckBox();
            this.InitialCatalogTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsPanel.Controls.Add(this.IgnoreButton);
            this.ButtonsPanel.Controls.Add(this.OkButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 214);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(488, 49);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // IgnoreButton
            // 
            this.IgnoreButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IgnoreButton.Location = new System.Drawing.Point(288, 9);
            this.IgnoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.IgnoreButton.Name = "IgnoreButton";
            this.IgnoreButton.Size = new System.Drawing.Size(88, 32);
            this.IgnoreButton.TabIndex = 1;
            this.IgnoreButton.Text = "صرف نظر";
            this.IgnoreButton.UseVisualStyleBackColor = true;
            this.IgnoreButton.Click += new System.EventHandler(this.IgnoreButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Location = new System.Drawing.Point(384, 9);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 32);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "برقراری ارتباط";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(263, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(258, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "تنظیمات اتصال به سرور و بانک اطلاعاتی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.UserIdCheckBox);
            this.MainPanel.Controls.Add(this.InitialCatalogTextBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.UserIdTextBox);
            this.MainPanel.Controls.Add(this.DataSourceTextBox);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.MainPanel.Size = new System.Drawing.Size(488, 184);
            this.MainPanel.TabIndex = 0;
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserIdCheckBox.Location = new System.Drawing.Point(37, 65);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(85, 27);
            this.UserIdCheckBox.TabIndex = 1;
            this.UserIdCheckBox.Text = "نام کاربری";
            this.UserIdCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            this.UserIdCheckBox.CheckedChanged += new System.EventHandler(this.UserIdCheckBox_CheckedChanged);
            // 
            // InitialCatalogTextBox
            // 
            this.InitialCatalogTextBox.Enabled = false;
            this.InitialCatalogTextBox.Location = new System.Drawing.Point(144, 133);
            this.InitialCatalogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InitialCatalogTextBox.Name = "InitialCatalogTextBox";
            this.InitialCatalogTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InitialCatalogTextBox.Size = new System.Drawing.Size(307, 30);
            this.InitialCatalogTextBox.TabIndex = 4;
            this.InitialCatalogTextBox.Text = "parsysdb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "بانک اطلاعاتی";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(144, 97);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(307, 30);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "رمز عبور";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(144, 61);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserIdTextBox.Size = new System.Drawing.Size(307, 30);
            this.UserIdTextBox.TabIndex = 2;
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(144, 25);
            this.DataSourceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataSourceTextBox.Size = new System.Drawing.Size(307, 30);
            this.DataSourceTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "آدرس سرور";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionHandlerForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 263);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionHandlerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlConnectionHandlerForm";
            this.Load += new System.EventHandler(this.SqlConnectionHandlerForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button IgnoreButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox UserIdCheckBox;
        private System.Windows.Forms.TextBox InitialCatalogTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.Label label1;
    }
}