using Parsys.DataLayer.Connections.ProviderAbstracts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys.WinClient.Views.WelcomeForms
{


    public partial class SplashScreenForm : Form
    {
        IConnection myConnection;


        public SplashScreenForm(IConnection connection)
        {
            myConnection = connection;
            InitializeComponent();
        }


        private async void SplashScreenForm_Load(object sender, EventArgs e)
        {
            ProgressLabel.Text = "درحال بررسی ارتباط با سرور";
            while (!await myConnection.CheckConnection())
            {
                ProgressLabel.Text = "ارتباط با سرور برقرار نشد";
                var container = new StructureMap.Container(new IoC.TypesRegistery());
                var connectionHandler = container.GetInstance<ConnectionHandlerForm>();
                var result = connectionHandler.ShowDialog();
                if (result != DialogResult.OK)
                    DialogResult = DialogResult.Cancel;
                ProgressLabel.Text = "تلاش مجدد برای برقراری ارتباط با سرور";
                myConnection.GetConnection();
                
            }
            await Task.Delay(2340);
            ProgressLabel.Text = "درحال بررسی ارتباط با بانک اطلاعاتی";
            if(!await myConnection.CheckDatabase())
            {
                await Task.Delay(1690);
                ProgressLabel.Text = "پیکربندی بانک اطلاعاتی";
                await myConnection.CreateDatabase(Properties.Resources.script);
                await Task.Delay(3320);
            }
            ProgressLabel.Text = "ارتباط با بانک اطلاعاتی با موفقیت برقرار شد";
            await Task.Delay(3105);
            DialogResult = DialogResult.OK;
        }



    }



}


