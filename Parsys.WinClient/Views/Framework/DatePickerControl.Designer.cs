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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.DaysDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.TodayButton = new System.Windows.Forms.Button();
            this.CurrentDayButton = new System.Windows.Forms.Button();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MonthComboBox);
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
            this.BottomPanel.Controls.Add(this.SelectedDateLabel);
            this.BottomPanel.Controls.Add(this.CurrentDayButton);
            this.BottomPanel.Controls.Add(this.TodayButton);
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
            this.YearTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.YearTextBox.Location = new System.Drawing.Point(102, 0);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(184, 35);
            this.YearTextBox.TabIndex = 2;
            this.YearTextBox.Text = "1401";
            this.YearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.Font = new System.Drawing.Font("Tahoma", 17F);
            this.MonthComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
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
            this.MonthComboBox.Location = new System.Drawing.Point(102, 38);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(184, 36);
            this.MonthComboBox.TabIndex = 3;
            // 
            // DaysDataGridView
            // 
            this.DaysDataGridView.AllowUserToAddRows = false;
            this.DaysDataGridView.AllowUserToDeleteRows = false;
            this.DaysDataGridView.AllowUserToOrderColumns = true;
            this.DaysDataGridView.AllowUserToResizeColumns = false;
            this.DaysDataGridView.AllowUserToResizeRows = false;
            this.DaysDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaysDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DaysDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DaysDataGridView.ColumnHeadersHeight = 35;
            this.DaysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaturdayColumn,
            this.SundayColumn,
            this.MondayColumn,
            this.TuesdayColumn,
            this.WednesdayColumn,
            this.ThursdayColumn,
            this.FridayColumn});
            this.DaysDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DaysDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DaysDataGridView.Location = new System.Drawing.Point(0, 74);
            this.DaysDataGridView.Name = "DaysDataGridView";
            this.DaysDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DaysDataGridView.RowHeadersVisible = false;
            this.DaysDataGridView.Size = new System.Drawing.Size(388, 249);
            this.DaysDataGridView.TabIndex = 4;
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SelectedDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectedDateLabel.Location = new System.Drawing.Point(102, 8);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SelectedDateLabel.Size = new System.Drawing.Size(184, 27);
            this.SelectedDateLabel.TabIndex = 4;
            this.SelectedDateLabel.Text = "23 مرداد 1401";
            this.SelectedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TodayButton
            // 
            this.TodayButton.BackColor = System.Drawing.Color.LightCyan;
            this.TodayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.TodayButton.Location = new System.Drawing.Point(296, 0);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(92, 42);
            this.TodayButton.TabIndex = 5;
            this.TodayButton.Text = "امروز";
            this.TodayButton.UseVisualStyleBackColor = false;
            // 
            // CurrentDayButton
            // 
            this.CurrentDayButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CurrentDayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentDayButton.ForeColor = System.Drawing.Color.White;
            this.CurrentDayButton.Location = new System.Drawing.Point(0, 0);
            this.CurrentDayButton.Name = "CurrentDayButton";
            this.CurrentDayButton.Size = new System.Drawing.Size(92, 42);
            this.CurrentDayButton.TabIndex = 5;
            this.CurrentDayButton.Text = "روز انتخابی";
            this.CurrentDayButton.UseVisualStyleBackColor = false;
            // 
            // SaturdayColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.SaturdayColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaturdayColumn.HeaderText = "شنبه";
            this.SaturdayColumn.Name = "SaturdayColumn";
            // 
            // SundayColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.SundayColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SundayColumn.HeaderText = "یک‌شنبه";
            this.SundayColumn.Name = "SundayColumn";
            // 
            // MondayColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.MondayColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.MondayColumn.HeaderText = "دوشنبه";
            this.MondayColumn.Name = "MondayColumn";
            // 
            // TuesdayColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.TuesdayColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TuesdayColumn.HeaderText = "سه‌شنبه";
            this.TuesdayColumn.Name = "TuesdayColumn";
            // 
            // WednesdayColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.WednesdayColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.WednesdayColumn.HeaderText = "چهارشنبه";
            this.WednesdayColumn.Name = "WednesdayColumn";
            // 
            // ThursdayColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.ThursdayColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ThursdayColumn.HeaderText = "پنج‌شنبه";
            this.ThursdayColumn.Name = "ThursdayColumn";
            // 
            // FridayColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.FridayColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.FridayColumn.HeaderText = "جمعه";
            this.FridayColumn.Name = "FridayColumn";
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
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Button PreviousYearButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView DaysDataGridView;
        private System.Windows.Forms.Label SelectedDateLabel;
        private System.Windows.Forms.Button CurrentDayButton;
        private System.Windows.Forms.Button TodayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
    }
}
