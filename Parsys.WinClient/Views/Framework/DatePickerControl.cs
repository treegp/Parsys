﻿using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.Framework
{
    public partial class DatePickerControl : UserControl
    {
        public Calendar PerCalendar = new PersianCalendar();
        public DateTime ReturnDate;

        public DatePickerControl()
        {

            InitializeComponent();
            MonthListBox.DrawMode = DrawMode.OwnerDrawFixed;
            MonthListBox.DrawItem += new DrawItemEventHandler(ListBoxDrawItem);
            YearListBox.DrawMode = DrawMode.OwnerDrawFixed;
            YearListBox.DrawItem += new DrawItemEventHandler(ListBoxDrawItem);

            void ListBoxDrawItem(object sender, DrawItemEventArgs e)
            {
                ListBox list = (ListBox)sender;
                if (e.Index > -1)
                {
                    object item = list.Items[e.Index];
                    e.DrawBackground();
                    e.DrawFocusRectangle();
                    Brush brush = new SolidBrush(e.ForeColor);
                    SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                    e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
                }
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            ReturnDate = new DateTime(PerCalendar.GetYear(DateTime.Now), PerCalendar.GetMonth(DateTime.Now),
                PerCalendar.GetDayOfMonth(DateTime.Now), PerCalendar);

            RefreshCalendar( PerCalendar.GetYear(DateTime.Now), PerCalendar.GetMonth(DateTime.Now));
            MonthListBox.SelectedItem = MonthLabel.Text;
            base.OnLoad(e);
        }



        protected void RefreshCalendar(int y, int m, int? d = null)
        {
            DaysDataGridView.Rows.Clear();
            MonthLabel.Text = MonthListBox.Items[m - 1].ToString();
            YearLabel.Text = y.ToString();


            int dINm = PerCalendar.GetDaysInMonth(y, m);
            int dINlastm = m == 1 ? PerCalendar.GetDaysInMonth(y - 1, 12) : PerCalendar.GetDaysInMonth(y, m - 1);

            DaysDataGridView.Rows.Add(6);
            int dayIndex;
            int rowIndex = 0;


            int weekIndex = 1 + (int)PerCalendar.GetDayOfWeek(new DateTime(y, m, 1, PerCalendar));

            if (weekIndex != 7)
            {
                int lastMonthWeekIndex = 0;
                for (dayIndex = dINlastm - weekIndex + 1; dayIndex <= dINlastm; dayIndex++)
                {

                    DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Value = dayIndex;
                    DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Style.ForeColor = Color.Gainsboro;

                    if (m == 1)
                    {
                        DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Tag =
                            new DateTime(y - 1, 12, dayIndex, PerCalendar);
                    }
                    else
                    {
                        DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Tag =
                            new DateTime(y, m - 1, dayIndex, PerCalendar);
                    }

                    lastMonthWeekIndex++;
                }
            }
            else weekIndex = 0;


            for (dayIndex = 1; dayIndex <= dINm; dayIndex++)
            {
                DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Value = dayIndex;
                DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Tag =
                    new DateTime(y, m, dayIndex, PerCalendar);



                if ((DateTime)DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Tag == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
                {
                    DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Style.ForeColor = Color.White;
                    DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Style.BackColor = Color.LightSeaGreen;
                }

                weekIndex++;
                if (weekIndex == 7)
                {
                    rowIndex++;
                    weekIndex = 0;
                }
            }

            //next month
            if (rowIndex < 6)
            {
                for (dayIndex = 1; rowIndex < 6; dayIndex++)
                {
                    DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Value = dayIndex;
                    DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Style.ForeColor = Color.Gainsboro;

                    if (m == 12)
                    {
                        DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Tag =
                            new DateTime(y + 1, 1, dayIndex, PerCalendar);
                    }
                    else
                    {
                        DaysDataGridView.Rows[rowIndex].Cells[weekIndex].Tag =
                            new DateTime(y, m + 1, dayIndex, PerCalendar);
                    }

                    weekIndex++;
                    if (weekIndex == 7)
                    {
                        rowIndex++;
                        weekIndex = 0;
                    }
                }
            }





            foreach (var row in DaysDataGridView.Rows.OfType<DataGridViewRow>())
            {
                row.Height = 30;
            }
        }







        private void DaysDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DaysDataGridView.SelectedCells.Count != 0)
                if (DaysDataGridView.SelectedCells[0].Tag != null)
                {
                    SelectedDateLabel.Text = ((DateTime)DaysDataGridView.SelectedCells[0].Tag).ToString("d MMM yyyy");
                    ReturnDate = (DateTime)DaysDataGridView.SelectedCells[0].Tag;
                }
        }



        #region choose month and year
        private void MonthLabel_Click(object sender, EventArgs e)
        {
            if (MonthListBox.Visible)
                MonthListBox.Visible = false;
            else
            {
                YearListBox.Visible = false;
                MonthListBox.Visible = true;
                MonthListBox.SelectedItem = MonthLabel.Text;
            }


        }

        private void MonthListBox_Click(object sender, EventArgs e)
        {
            MonthListBox.Visible = false;
            MonthLabel.Text = MonthListBox.SelectedItem.ToString();
            RefreshCalendar(int.Parse(YearLabel.Text), MonthListBox.SelectedIndex + 1);
            DaysDataGridView.CurrentCell = null;
        }

        private void YearLabel_Click(object sender, EventArgs e)
        {
            if (YearListBox.Visible)
                YearListBox.Visible = false;
            else
            {
                MonthListBox.Visible = false;
                YearListBox.Visible = true;
                YearListBox.SelectedItem = YearLabel.Text;
            }

        }

        private void YearListBox_Click(object sender, EventArgs e)
        {
            YearListBox.Visible = false;
            YearLabel.Text = YearListBox.SelectedItem.ToString();
            RefreshCalendar( int.Parse(YearLabel.Text), MonthListBox.SelectedIndex + 1);
            DaysDataGridView.CurrentCell = null;
        }
        #endregion

        private void CurrentDayButton_Click(object sender, EventArgs e)
        {
            RefreshCalendar(PerCalendar.GetYear(ReturnDate), PerCalendar.GetMonth(ReturnDate));

        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            RefreshCalendar( PerCalendar.GetYear(DateTime.Now), PerCalendar.GetMonth(DateTime.Now));
        }
    }
}
