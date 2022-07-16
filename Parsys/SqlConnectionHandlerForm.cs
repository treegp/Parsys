using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parsys.WinClient
{
    public partial class SqlConnectionHandlerForm : Form
    {
        public SqlConnectionStringBuilder conBuilder;
        public SqlConnectionHandlerForm(SqlConnectionStringBuilder conBuilder)
        {
            this.conBuilder = conBuilder;
            InitializeComponent();
        }



        private void UserIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = PasswordTextBox.Enabled = UserIdCheckBox.Checked;

            if (UserIdCheckBox.Checked)
                UserIdTextBox.Select();
        }

        private void SqlConnectionHandlerForm_Load(object sender, EventArgs e)
        {
            DataSourceTextBox.Text = conBuilder.DataSource;
            UserIdCheckBox.Checked = !conBuilder.IntegratedSecurity;
            if (UserIdCheckBox.Checked)
            {
                UserIdTextBox.Text = conBuilder.UserID;
                PasswordTextBox.Text = conBuilder.Password;
            }
            InitialCatalogTextBox.Text = "parsysdb";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder() ;
            conBuilder.DataSource = DataSourceTextBox.Text;
            conBuilder.IntegratedSecurity = !UserIdCheckBox.Checked;
            if (UserIdCheckBox.Checked)
            {
                conBuilder.UserID = UserIdTextBox.Text;
                conBuilder.Password = PasswordTextBox.Text;
            }
            conBuilder.InitialCatalog = "parsysdb";
            this.conBuilder = conBuilder;
            return;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.conBuilder = null;
            return;
        }
    }
}
