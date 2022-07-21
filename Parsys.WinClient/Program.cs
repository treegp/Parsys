using Parsys.WinClient.Views.WelcomeForms;
using System;
using System.Windows.Forms;

namespace Parsys.WinClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new StructureMap.Container(new IoC.TypesRegistery());
            var splashScreen = container.GetInstance<SplashScreenForm>();
            var result = splashScreen.ShowDialog();
            if (result != DialogResult.OK)
                return;

            Application.Run(new MainForm());
        }
    }
}
