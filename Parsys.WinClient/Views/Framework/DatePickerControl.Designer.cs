namespace Parsys.WinClient.Views.Framework
{
    partial class DatePickerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.ComboBox();
            this.DaysDataGridView = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MonthTextBox);
            this.TopPanel.Controls.Add(this.YearTextBox);
            this.TopPanel.Controls.Add(this.NextMonthButton);
            this.TopPanel.Controls.Add(this.NextYearButton);
            this.TopPanel.Controls.Add(this.PreviousMonthButton);
            this.TopPanel.Controls.Add(this.PreviousYearButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(388, 74);
            this.TopPanel.TabIndex = 2;
            // 
            // PreviousYearButton
            // 
            this.PreviousYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousYearButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousYearButton.Name = "PreviousYearButton";
            this.PreviousYearButton.Size = new System.Drawing.Size(51, 74);
            this.PreviousYearButton.TabIndex = 1;
            this.PreviousYearButton.Text = "<<";
            this.PreviousYearButton.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 323);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(388, 42);
            this.BottomPanel.TabIndex = 3;
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousMonthButton.Location = new System.Drawing.Point(51, 0);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(51, 74);
            this.PreviousMonthButton.TabIndex = 1;
            this.PreviousMonthButton.Text = "<";
            this.PreviousMonthButton.UseVisualStyleBackColor = true;
            // 
            // NextYearButton
            // 
            this.NextYearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextYearButton.Location = new System.Drawing.Point(337, 0);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(51, 74);
            this.NextYearButton.TabIndex = 1;
            this.NextYearButton.Text = ">>";
            this.NextYearButton.UseVisualStyleBackColor = true;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextMonthButton.Location = new System.Drawing.Point(286, 0);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(51, 74);
            this.NextMonthButton.TabIndex = 1;
            this.NextMonthButton.Text = ">";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearTextBox.Font = new System.Drawing.Font("Tahoma", 17F);
            this.YearTextBox.Location = new System.Drawing.Point(102, 0);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(184, 35);
            this.YearTextBox.TabIndex = 2;
            this.YearTextBox.Text = "1401";
            this.YearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MonthTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthTextBox.Font = new System.Drawing.Font("Tahoma", 17F);
            this.MonthTextBox.FormattingEnabled = true;
            this.MonthTextBox.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.MonthTextBox.Location = new System.Drawing.Point(102, 38);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(184, 36);
            this.MonthTextBox.TabIndex = 3;
            // 
            // DaysDataGridView
            // 
            this.DaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaysDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DaysDataGridView.Location = new System.Drawing.Point(0, 74);
            this.DaysDataGridView.Name = "DaysDataGridView";
            this.DaysDataGridView.Size = new System.Drawing.Size(388, 249);
            this.DaysDataGridView.TabIndex = 4;
            // 
            // DatePickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DaysDataGridView);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "DatePickerControl";
            this.Size = new System.Drawing.Size(388, 365);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ComboBox MonthTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Button PreviousYearButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView DaysDataGridView;
    }
}
