using System;
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
        }

        protected override void OnLoad(EventArgs e)
        {
            int d = PerCalendar.GetDayOfMonth(DateTime.Now);
            int m = 4; //PerCalendar.GetMonth(DateTime.Now);
            int y = PerCalendar.GetYear(DateTime.Now);

            int dINm = PerCalendar.GetDaysInMonth(y, m);
            int dINlastm = m == 1 ? PerCalendar.GetDaysInMonth(y - 1, 12) : PerCalendar.GetDaysInMonth(y, m - 1);

            DaysDataGridView.Rows.Add(6);
            int dayIndex;
            int weekIndex;
            int rowIndex = 0;


            weekIndex = 1 + (int)PerCalendar.GetDayOfWeek(new DateTime(y, m, 1, PerCalendar));

            if (weekIndex != 7)
            {
                int lastMonthWeekIndex = 0;
                for (dayIndex = dINlastm - weekIndex+1; dayIndex <= dINlastm; dayIndex++)
                {
                    
                    DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Value = dayIndex;
                    DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Style.ForeColor = Color.Gainsboro;

                    if (m == 1)
                    {
                        DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Tag =
                            new DateTime(y-1, 12, dayIndex, PerCalendar);
                    }
                    else
                    {
                        DaysDataGridView.Rows[rowIndex].Cells[lastMonthWeekIndex].Tag =
                            new DateTime(y, m-1, dayIndex, PerCalendar);
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


                weekIndex++;
                if (weekIndex == 7)
                {
                    rowIndex++;
                    weekIndex = 0;
                }


            }



            foreach (var row in DaysDataGridView.Rows.OfType<DataGridViewRow>())
            {
                row.Height = 30;
            }






            base.OnLoad(e);
        }

        private void DaysDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DaysDataGridView.SelectedCells[0].Tag != null)
                SelectedDateLabel.Text = ((DateTime)DaysDataGridView.SelectedCells[0].Tag).ToString("d MMM yyyy");
        }
    }
}
