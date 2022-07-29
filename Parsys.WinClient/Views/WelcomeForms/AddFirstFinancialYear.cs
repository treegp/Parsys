using System;
using System.Globalization;
using System.Windows.Forms;


namespace Parsys.WinClient.Views.WelcomeForms
{
    public partial class AddFirstFinancialYear : Form
    {

        public FinancialYearFormModel FinancialYear = new FinancialYearFormModel();

        public AddFirstFinancialYear(string corporationTitle)
        {
            InitializeComponent();

            CorporationTitleTextBox.Text = corporationTitle;
            TitleTextBox.DataBindings.Add("Text", FinancialYear, "Title");
            DescriptionTextBox.DataBindings.Add("Text", FinancialYear, "Description");
            StartDateMaskedTextBox.DataBindings.Add("Text", FinancialYear, "StartDateString");
            FinishDateMaskedTextBox.DataBindings.Add("Text", FinancialYear, "FinishDateString");

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            FormErrorProvider.Clear();
            if (TitleTextBox.Text == "")
                FormErrorProvider.SetError(TitleTextBox, "عنوان نمی تواند خالی باشد");
            else if (FinancialYear.StartDate.Year == 1)
                FormErrorProvider.SetError(StartDateMaskedTextBox, "تاریخ افتتاح سال مالی نامعتبر است");
            else if (FinancialYear.FinishDate.Year == 1)
                FormErrorProvider.SetError(FinishDateMaskedTextBox, "تاریخ اختتام سال مالی نامعتبر است");
            else
                DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        public class FinancialYearFormModel
        {


            public string Title { get; set; }
            public string Description { get; set; }
            public string StartDateString { get; set; }
            public string FinishDateString { get; set; }

            public DateTime StartDate
            {
                get
                {
                    try
                    {
                        DateTime dt = new DateTime(int.Parse(StartDateString.Split('/')[0]),
                            int.Parse(StartDateString.Split('/')[1]), int.Parse(StartDateString.Split('/')[2]),
                            new PersianCalendar());
                        return dt;
                    }
                    catch
                    {
                        return new DateTime(1, 1, 1);
                    }

                }
            }

            public DateTime FinishDate
            {
                get
                {
                    try
                    {
                        DateTime dt = new DateTime(int.Parse(FinishDateString.Split('/')[0]),
                            int.Parse(FinishDateString.Split('/')[1]), int.Parse(FinishDateString.Split('/')[2]),
                            new PersianCalendar());
                        return dt;
                    }
                    catch
                    {
                        return new DateTime(1, 1, 1);
                    }
                }
            }

        }
    }
}
