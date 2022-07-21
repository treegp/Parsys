using Parsys.DataLayer.Connections.ProviderAbstracts;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.WelcomeForms
{
    public partial class ConnectionHandlerForm : Form
    {

        IConnection myConnection;
        public ConnectionHandlerForm(IConnection connection)
        {
            myConnection = connection;
            InitializeComponent();
        }

        private void SqlConnectionHandlerForm_Load(object sender, EventArgs e)
        {
            CatchItemsFromSQL();
        }

        private void IgnoreButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            PushItemsToSQL();
            DialogResult = DialogResult.OK;
        }

        private void UserIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = PasswordTextBox.Enabled = UserIdCheckBox.Checked;
        }












        private void CatchItemsFromSQL()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.ConnectionString = myConnection.GetConnection();

            DataSourceTextBox.Text = sqlConnectionStringBuilder.DataSource;
            UserIdCheckBox.Checked = !sqlConnectionStringBuilder.IntegratedSecurity;
            if (!sqlConnectionStringBuilder.IntegratedSecurity)
            {
                UserIdTextBox.Text = sqlConnectionStringBuilder.UserID;
                PasswordTextBox.Text = sqlConnectionStringBuilder.Password;
            }
            InitialCatalogTextBox.Text = myConnection.DbConnectionName;
        }

        private void PushItemsToSQL()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

            sqlConnectionStringBuilder.DataSource = DataSourceTextBox.Text;
            sqlConnectionStringBuilder.IntegratedSecurity = !UserIdCheckBox.Checked;
            if (UserIdCheckBox.Checked)
            {
                sqlConnectionStringBuilder.UserID = UserIdTextBox.Text;
                sqlConnectionStringBuilder.Password = PasswordTextBox.Text;
            }
            sqlConnectionStringBuilder.InitialCatalog = myConnection.DbConnectionName;

            myConnection.SetConnection(sqlConnectionStringBuilder.ConnectionString);
        }
    }
}
