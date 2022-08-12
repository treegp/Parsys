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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.CurrentDayButton = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.DaysDataGridView = new System.Windows.Forms.DataGridView();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.YearMaskedTextBox);
            this.TopPanel.Controls.Add(this.MonthComboBox);
            this.TopPanel.Controls.Add(this.NextMonthButton);
            this.TopPanel.Controls.Add(this.NextYearButton);
            this.TopPanel.Controls.Add(this.PreviousMonthButton);
            this.TopPanel.Controls.Add(this.PreviousYearButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(298, 56);
            this.TopPanel.TabIndex = 2;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonthComboBox.Font = new System.Drawing.Font("Tahoma", 12F);
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
            this.MonthComboBox.Location = new System.Drawing.Point(75, 29);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(148, 27);
            this.MonthComboBox.TabIndex = 3;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextMonthButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextMonthButton.Location = new System.Drawing.Point(223, 0);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(40, 56);
            this.NextMonthButton.TabIndex = 1;
            this.NextMonthButton.Text = "<";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            // 
            // NextYearButton
            // 
            this.NextYearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextYearButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextYearButton.Location = new System.Drawing.Point(263, 0);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(35, 56);
            this.NextYearButton.TabIndex = 1;
            this.NextYearButton.Text = "<<";
            this.NextYearButton.UseVisualStyleBackColor = true;
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousMonthButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PreviousMonthButton.Location = new System.Drawing.Point(35, 0);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(40, 56);
            this.PreviousMonthButton.TabIndex = 1;
            this.PreviousMonthButton.Text = ">";
            this.PreviousMonthButton.UseVisualStyleBackColor = true;
            // 
            // PreviousYearButton
            // 
            this.PreviousYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousYearButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PreviousYearButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousYearButton.Name = "PreviousYearButton";
            this.PreviousYearButton.Size = new System.Drawing.Size(35, 56);
            this.PreviousYearButton.TabIndex = 1;
            this.PreviousYearButton.Text = ">>";
            this.PreviousYearButton.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.SelectedDateLabel);
            this.BottomPanel.Controls.Add(this.CurrentDayButton);
            this.BottomPanel.Controls.Add(this.TodayButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 262);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(298, 36);
            this.BottomPanel.TabIndex = 3;
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedDateLabel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SelectedDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectedDateLabel.Location = new System.Drawing.Point(75, 0);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SelectedDateLabel.Size = new System.Drawing.Size(148, 36);
            this.SelectedDateLabel.TabIndex = 4;
            this.SelectedDateLabel.Text = "23 مرداد 1401";
            this.SelectedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentDayButton
            // 
            this.CurrentDayButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CurrentDayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentDayButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CurrentDayButton.ForeColor = System.Drawing.Color.White;
            this.CurrentDayButton.Location = new System.Drawing.Point(0, 0);
            this.CurrentDayButton.Name = "CurrentDayButton";
            this.CurrentDayButton.Size = new System.Drawing.Size(75, 36);
            this.CurrentDayButton.TabIndex = 5;
            this.CurrentDayButton.Text = "روز انتخابی";
            this.CurrentDayButton.UseVisualStyleBackColor = false;
            // 
            // TodayButton
            // 
            this.TodayButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TodayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.TodayButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TodayButton.ForeColor = System.Drawing.Color.White;
            this.TodayButton.Location = new System.Drawing.Point(223, 0);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(75, 36);
            this.TodayButton.TabIndex = 5;
            this.TodayButton.Text = "امروز";
            this.TodayButton.UseVisualStyleBackColor = false;
            // 
            // DaysDataGridView
            // 
            this.DaysDataGridView.AllowUserToAddRows = false;
            this.DaysDataGridView.AllowUserToDeleteRows = false;
            this.DaysDataGridView.AllowUserToResizeColumns = false;
            this.DaysDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DaysDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.DaysDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaysDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Tahoma", 6F);
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DaysDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.DaysDataGridView.ColumnHeadersHeight = 35;
            this.DaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.DaysDataGridView.Location = new System.Drawing.Point(0, 56);
            this.DaysDataGridView.MultiSelect = false;
            this.DaysDataGridView.Name = "DaysDataGridView";
            this.DaysDataGridView.ReadOnly = true;
            this.DaysDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DaysDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DaysDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.DaysDataGridView.RowHeadersVisible = false;
            this.DaysDataGridView.RowHeadersWidth = 40;
            this.DaysDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DaysDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle55;
            this.DaysDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DaysDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DaysDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DaysDataGridView.Size = new System.Drawing.Size(298, 206);
            this.DaysDataGridView.TabIndex = 4;
            this.DaysDataGridView.TabStop = false;
            // 
            // SaturdayColumn
            // 
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.SaturdayColumn.DefaultCellStyle = dataGridViewCellStyle47;
            this.SaturdayColumn.HeaderText = "شـ";
            this.SaturdayColumn.Name = "SaturdayColumn";
            this.SaturdayColumn.ReadOnly = true;
            // 
            // SundayColumn
            // 
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.SundayColumn.DefaultCellStyle = dataGridViewCellStyle48;
            this.SundayColumn.HeaderText = "یـ";
            this.SundayColumn.Name = "SundayColumn";
            this.SundayColumn.ReadOnly = true;
            // 
            // MondayColumn
            // 
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.MondayColumn.DefaultCellStyle = dataGridViewCellStyle49;
            this.MondayColumn.HeaderText = "د";
            this.MondayColumn.Name = "MondayColumn";
            this.MondayColumn.ReadOnly = true;
            // 
            // TuesdayColumn
            // 
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.TuesdayColumn.DefaultCellStyle = dataGridViewCellStyle50;
            this.TuesdayColumn.HeaderText = "سـ";
            this.TuesdayColumn.Name = "TuesdayColumn";
            this.TuesdayColumn.ReadOnly = true;
            // 
            // WednesdayColumn
            // 
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.WednesdayColumn.DefaultCellStyle = dataGridViewCellStyle51;
            this.WednesdayColumn.HeaderText = "چـ";
            this.WednesdayColumn.Name = "WednesdayColumn";
            this.WednesdayColumn.ReadOnly = true;
            // 
            // ThursdayColumn
            // 
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.ThursdayColumn.DefaultCellStyle = dataGridViewCellStyle52;
            this.ThursdayColumn.HeaderText = "پـ";
            this.ThursdayColumn.Name = "ThursdayColumn";
            this.ThursdayColumn.ReadOnly = true;
            // 
            // FridayColumn
            // 
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.FridayColumn.DefaultCellStyle = dataGridViewCellStyle53;
            this.FridayColumn.HeaderText = "جـ";
            this.FridayColumn.Name = "FridayColumn";
            this.FridayColumn.ReadOnly = true;
            // 
            // YearMaskedTextBox
            // 
            this.YearMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.YearMaskedTextBox.Location = new System.Drawing.Point(75, 0);
            this.YearMaskedTextBox.Mask = "1000";
            this.YearMaskedTextBox.Name = "YearMaskedTextBox";
            this.YearMaskedTextBox.PromptChar = '-';
            this.YearMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YearMaskedTextBox.Size = new System.Drawing.Size(148, 20);
            this.YearMaskedTextBox.TabIndex = 4;
            this.YearMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatePickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DaysDataGridView);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "DatePickerControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(298, 298);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ComboBox MonthComboBox;
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
        private System.Windows.Forms.MaskedTextBox YearMaskedTextBox;
    }
}
