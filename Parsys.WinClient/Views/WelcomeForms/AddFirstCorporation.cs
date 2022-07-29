using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.WelcomeForms
{
    public partial class AddFirstCorporation : Form
    {
        public Corporations Corporation { get; set; }

        public AddFirstCorporation(Corporations corporation)
        {
            InitializeComponent();
            Corporation = corporation;
            TitleTextBox.DataBindings.Add("Text", Corporation, "Title");
            TelephoneTextBox.DataBindings.Add("Text", Corporation, "Telephone");
            FaxTextBox.DataBindings.Add("Text", Corporation, "Fax");
            AddressTextBox.DataBindings.Add("Text", Corporation, "Address");
            DescriptionTextBox.DataBindings.Add("Text", Corporation, "Description");



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "")
                FormErrorProvider.SetError(TitleTextBox, "عنوان شرکت/سازمان نمی تواند خالی باشد");
            else
                DialogResult = DialogResult.OK;
        }
    }
}
