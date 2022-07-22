using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.WelcomeForms;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Parsys.WinClient.ApplicationMethods;

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
            var splashScreenForm = container.GetInstance<SplashScreenForm>();
            var splashScreenResult = splashScreenForm.ShowDialog();
            if (splashScreenResult != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            var connection = ConfigurationManager.ConnectionStrings["PARSYS"].ConnectionString;
            CorporationsRepository corpo = new CorporationsRepository(connection);

            if (corpo.Count() == 0)
            {
                Corporations firstCorporation = new Corporations();

                AddFirstCorporation corpoForm = new AddFirstCorporation(firstCorporation);
                var corpoResult = corpoForm.ShowDialog();

                if (corpoResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                corpo.Insert(firstCorporation);
            }


            FinancialYearsRepository finance = new FinancialYearsRepository(connection);

            var corpoId = corpo.GetAll().Select(c => c.Id).First();
            if (!finance.GetByCorporationId(corpoId).Any())
            {
                FinancialYears firstFinancialYear = new FinancialYears();
                
                AddFirstFinancialYear financeForm = new AddFirstFinancialYear(corpo.GetById(corpoId).Select(c=>c.Title).First());
                var financeResult = financeForm.ShowDialog();

                if (financeResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                firstFinancialYear.CorporationId = corpoId;
                firstFinancialYear.Title = financeForm.FinancialYear.Title;
                firstFinancialYear.Description= financeForm.FinancialYear.Description;
                firstFinancialYear.StartDate = (DateTime) DateTimeConverter.ShamsiStringToMiladiDateTime(financeForm.FinancialYear.StartDate);
                firstFinancialYear.FinishDate = (DateTime)DateTimeConverter.ShamsiStringToMiladiDateTime(financeForm.FinancialYear.FinishDate);

                finance.Insert(firstFinancialYear);

            }



            Application.Run(new MainForm());
        }
    }
}
