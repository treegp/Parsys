using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parsys.WinClient
{


    public partial class SplashScreenForm : Form
    {



        public static string DefaultInitialCatalogValue { get { return "parsysdb"; } }

        public SplashScreenForm()
        {

            InitializeComponent();
        }

        private async void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenProgressBar.MarqueeAnimationSpeed = 25;
            ProgressLabel.Text = "برقراری ارتباط با سرور";

            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.ConnectionString = ConfigurationManager.ConnectionStrings["PARSYS"].ConnectionString;
            SqlConnectionHandlerForm configServerForm = new SqlConnectionHandlerForm(connectionBuilder.ConnectionString);
            DataLayer.ConnectTo myConnection = new DataLayer.ConnectTo();

            while (await myConnection.ServerOrDatabase(connectionBuilder.ConnectionString, true) == 0)
            {
                ProgressLabel.Text = "ارتباط با سرور برقرار نشد";

                configServerForm.ShowDialog();
                if (configServerForm.connectStringBuilder == null)
                    return;
                else
                    connectionBuilder = configServerForm.connectStringBuilder;
                ProgressLabel.Text = "برقراری ارتباط با سرور";
            }

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var conSec = (ConnectionStringsSection)config.GetSection("connectionStrings");
            conSec.ConnectionStrings["PARSYS"].ConnectionString = configServerForm.connectStringBuilder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            connectionBuilder.ConnectionString = configServerForm.connectStringBuilder.ConnectionString;

            ProgressLabel.Text = "بررسی دیتابیس";
            while (await myConnection.ServerOrDatabase(connectionBuilder.ConnectionString, false) == 0)
            {
                connectionBuilder.InitialCatalog = "master";
                ProgressLabel.Text = "پیکربندی بانک اطلاعاتی در سرور";
                await myConnection.InitialDatabase(connectionBuilder.ConnectionString, DefaultInitialCatalogValue);

                connectionBuilder.InitialCatalog = DefaultInitialCatalogValue;
                ProgressLabel.Text = "ایجاد جداول در بانک اطلاعاتی";
                await myConnection.InitialDatabase(connectionBuilder.ConnectionString,Properties.Resources.ShopDb_Query.Replace("[ShopDb]","["+DefaultInitialCatalogValue+"]"));
                MessageBox.Show("دیتابیس با موفقیت ساخته شد");
            }


            MessageBox.Show("با موفقیت به دیتابیس متصل شدید");

        }






    }



}


