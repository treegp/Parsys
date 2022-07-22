using System;
using System.Windows.Forms;
using Parsys.DataLayer.Entities.EntityModels;


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
            StartDateMaskedTextBox.DataBindings.Add("Text", FinancialYear, "StartDate");
            FinishDateMaskedTextBox.DataBindings.Add("Text", FinancialYear, "FinishDate");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK; 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        public class FinancialYearFormModel
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string StartDate { get; set; }
            public string  FinishDate { get; set; }
        }
    }
}
