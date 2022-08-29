using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductParameters
{
    public partial class Editor : EntityEditorClass<DataLayer.Entities.EntityModels.ProductParameters>
    {
        public Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        public ProductParametersRepository Repo;
        public ProductCategoriesRepository CatRepo;
        

        public Editor()
        {
            
            InitializeComponent();

            Repo = new ProductParametersRepository(con.GetConnection());
            CatRepo = new ProductCategoriesRepository(con.GetConnection());

            Title = "";
            Id = "ProductParametersEditor";
            MultipleInstance = false;

            
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NewComboBox(i=>i.ProductCategoryId,"عنوان دسته بندی",CatRepo.GetByIsDeleted(false),i=>i.Title,i=>i.Id);
            NewTextBox(i => i.Title, "عنوان");
            NewTextBox(i => i.Key, "کلید");
            NewTextBox(i => i.Description, "توضیحات",true);
            ArrangementControls();

        }
    }
}
