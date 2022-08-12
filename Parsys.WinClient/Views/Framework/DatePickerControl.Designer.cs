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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.CurrentDayButton = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DaysDataGridView = new System.Windows.Forms.DataGridView();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthListBox = new System.Windows.Forms.ListBox();
            this.YearListBox = new System.Windows.Forms.ListBox();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.SelectedDateLabel);
            this.BottomPanel.Controls.Add(this.CurrentDayButton);
            this.BottomPanel.Controls.Add(this.TodayButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 272);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(298, 26);
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
            this.SelectedDateLabel.Size = new System.Drawing.Size(148, 26);
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
            this.CurrentDayButton.Size = new System.Drawing.Size(75, 26);
            this.CurrentDayButton.TabIndex = 5;
            this.CurrentDayButton.Text = "روز انتخابی";
            this.CurrentDayButton.UseVisualStyleBackColor = false;
            this.CurrentDayButton.Click += new System.EventHandler(this.CurrentDayButton_Click);
            // 
            // TodayButton
            // 
            this.TodayButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TodayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.TodayButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TodayButton.ForeColor = System.Drawing.Color.White;
            this.TodayButton.Location = new System.Drawing.Point(223, 0);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(75, 26);
            this.TodayButton.TabIndex = 5;
            this.TodayButton.Text = "امروز";
            this.TodayButton.UseVisualStyleBackColor = false;
            this.TodayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MonthLabel);
            this.TopPanel.Controls.Add(this.YearLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(298, 50);
            this.TopPanel.TabIndex = 9;
            // 
            // MonthLabel
            // 
            this.MonthLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonthLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthLabel.Location = new System.Drawing.Point(0, 0);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(298, 21);
            this.MonthLabel.TabIndex = 0;
            this.MonthLabel.Text = "فروردین";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonthLabel.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.YearLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.YearLabel.Location = new System.Drawing.Point(0, 29);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(298, 21);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "1401";
            this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YearLabel.Click += new System.EventHandler(this.YearLabel_Click);
            // 
            // DaysDataGridView
            // 
            this.DaysDataGridView.AllowUserToAddRows = false;
            this.DaysDataGridView.AllowUserToDeleteRows = false;
            this.DaysDataGridView.AllowUserToResizeColumns = false;
            this.DaysDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DaysDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DaysDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaysDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 7F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DaysDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DaysDataGridView.ColumnHeadersHeight = 25;
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
            this.DaysDataGridView.Location = new System.Drawing.Point(0, 50);
            this.DaysDataGridView.MultiSelect = false;
            this.DaysDataGridView.Name = "DaysDataGridView";
            this.DaysDataGridView.ReadOnly = true;
            this.DaysDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DaysDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DaysDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DaysDataGridView.RowHeadersVisible = false;
            this.DaysDataGridView.RowHeadersWidth = 40;
            this.DaysDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DaysDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DaysDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DaysDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DaysDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DaysDataGridView.Size = new System.Drawing.Size(298, 222);
            this.DaysDataGridView.TabIndex = 10;
            this.DaysDataGridView.TabStop = false;
            this.DaysDataGridView.SelectionChanged += new System.EventHandler(this.DaysDataGridView_SelectionChanged);
            // 
            // SaturdayColumn
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.SaturdayColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.SaturdayColumn.HeaderText = "شـ";
            this.SaturdayColumn.Name = "SaturdayColumn";
            this.SaturdayColumn.ReadOnly = true;
            // 
            // SundayColumn
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.SundayColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.SundayColumn.HeaderText = "یـ";
            this.SundayColumn.Name = "SundayColumn";
            this.SundayColumn.ReadOnly = true;
            // 
            // MondayColumn
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.MondayColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.MondayColumn.HeaderText = "د";
            this.MondayColumn.Name = "MondayColumn";
            this.MondayColumn.ReadOnly = true;
            // 
            // TuesdayColumn
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.TuesdayColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.TuesdayColumn.HeaderText = "سـ";
            this.TuesdayColumn.Name = "TuesdayColumn";
            this.TuesdayColumn.ReadOnly = true;
            // 
            // WednesdayColumn
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.WednesdayColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.WednesdayColumn.HeaderText = "چـ";
            this.WednesdayColumn.Name = "WednesdayColumn";
            this.WednesdayColumn.ReadOnly = true;
            // 
            // ThursdayColumn
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.ThursdayColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.ThursdayColumn.HeaderText = "پـ";
            this.ThursdayColumn.Name = "ThursdayColumn";
            this.ThursdayColumn.ReadOnly = true;
            // 
            // FridayColumn
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.FridayColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.FridayColumn.HeaderText = "جـ";
            this.FridayColumn.Name = "FridayColumn";
            this.FridayColumn.ReadOnly = true;
            // 
            // MonthListBox
            // 
            this.MonthListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MonthListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonthListBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MonthListBox.FormattingEnabled = true;
            this.MonthListBox.ItemHeight = 18;
            this.MonthListBox.Items.AddRange(new object[] {
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
            this.MonthListBox.Location = new System.Drawing.Point(0, 50);
            this.MonthListBox.Name = "MonthListBox";
            this.MonthListBox.Size = new System.Drawing.Size(298, 216);
            this.MonthListBox.TabIndex = 1;
            this.MonthListBox.Visible = false;
            this.MonthListBox.Click += new System.EventHandler(this.MonthListBox_Click);
            // 
            // YearListBox
            // 
            this.YearListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.YearListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearListBox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.YearListBox.FormattingEnabled = true;
            this.YearListBox.ItemHeight = 18;
            this.YearListBox.Items.AddRange(new object[] {
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420",
            "1421",
            "1422",
            "1423",
            "1424",
            "1425",
            "1426",
            "1427",
            "1428",
            "1429",
            "1430"});
            this.YearListBox.Location = new System.Drawing.Point(0, 50);
            this.YearListBox.Name = "YearListBox";
            this.YearListBox.Size = new System.Drawing.Size(298, 222);
            this.YearListBox.TabIndex = 11;
            this.YearListBox.Visible = false;
            this.YearListBox.Click += new System.EventHandler(this.YearListBox_Click);
            // 
            // DatePickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MonthListBox);
            this.Controls.Add(this.YearListBox);
            this.Controls.Add(this.DaysDataGridView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "DatePickerControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(298, 298);
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label SelectedDateLabel;
        private System.Windows.Forms.Button CurrentDayButton;
        private System.Windows.Forms.Button TodayButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.DataGridView DaysDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ListBox MonthListBox;
        private System.Windows.Forms.ListBox YearListBox;
    }
}
