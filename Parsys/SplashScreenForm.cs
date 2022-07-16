using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parsys.WinClient
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {

            InitializeComponent();
        }

        private async void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenProgressBar.MarqueeAnimationSpeed = 25;
            ProgressLabel.Text = "برقراری ارتباط با سرور";

            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder();
            SqlConnectionHandlerForm servForm = new SqlConnectionHandlerForm(conBuilder);



            conBuilder.ConnectionString = ConfigurationManager.ConnectionStrings["PARSYS"].ConnectionString;

            DataLayer.ConnectTo myConnection = new DataLayer.ConnectTo();

            while (await myConnection.ServerOrDatabase(conBuilder, true) == 0)
            {
                ProgressLabel.Text = "ارتباط با سرور برقرار نشد";

                servForm.ShowDialog();
                if (servForm.conBuilder == null)
                    return;
                else
                    conBuilder = servForm.conBuilder;
                ProgressLabel.Text = "برقراری ارتباط با سرور";
            }

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var conSec = (ConnectionStringsSection)config.GetSection("connectionStrings");
            conSec.ConnectionStrings["PARSYS"].ConnectionString= servForm.conBuilder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            conBuilder.ConnectionString = servForm.conBuilder.ConnectionString;

            ProgressLabel.Text = "بررسی دیتابیس";
            while (await myConnection.ServerOrDatabase(conBuilder, false) == 0)
            {
                ProgressLabel.Text = "پیکربندی دیتابیس در سرور";

            }


            MessageBox.Show("با موفقیت به دیتابیس متصل شدید");

        }






    }



}


