using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parsys.WinClient
{
    public partial class SqlConnectionHandlerForm : Form
    {
        public SqlConnectionStringBuilder connectStringBuilder=new SqlConnectionStringBuilder();
        public SqlConnectionHandlerForm(string connectStr)
        {
            InitializeComponent();
            connectStringBuilder.ConnectionString = connectStr;
        }



        private void UserIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = PasswordTextBox.Enabled = UserIdCheckBox.Checked;

            if (UserIdCheckBox.Checked)
                UserIdTextBox.Select();
        }

        private void SqlConnectionHandlerForm_Load(object sender, EventArgs e)
        {
            DataSourceTextBox.Text = connectStringBuilder.DataSource;
            UserIdCheckBox.Checked = !connectStringBuilder.IntegratedSecurity;
            if (UserIdCheckBox.Checked)
            {
                UserIdTextBox.Text = connectStringBuilder.UserID;
                PasswordTextBox.Text = connectStringBuilder.Password;
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
            connectStringBuilder = conBuilder;
            return;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            connectStringBuilder = null;
            return;
        }
    }
}
