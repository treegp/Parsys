using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int m = PerCalendar.GetMonth(DateTime.Now);
            int y = PerCalendar.GetYear(DateTime.Now);

            int dINm = PerCalendar.GetDaysInMonth(y,m);
            int dINlastm = m == 1 ? PerCalendar.GetDaysInMonth(y-1, 12) : PerCalendar.GetDaysInMonth(y, m-1);
            








            base.OnLoad(e);
        }
    }
}
