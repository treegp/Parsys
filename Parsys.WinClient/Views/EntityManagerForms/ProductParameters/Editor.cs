using Parsys.DataLayer.Connections.ProviderMethods;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.WinClient.Views.Framework;
using System;

namespace Parsys.WinClient.Views.EntityManagerForms.ProductParameters
{
    public partial class Editor : EntityEditorClass<DataLayer.Entities.EntityModels.ProductParameters>
    {
        public Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        public ProductParametersRepository Repo;
        public ProductCategoriesRepository CatRepo;
        public int CatId = 0;


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


            if (CatId == 0)
                NewComboBox(i => i.ProductCategoryId, "عنوان دسته بندی", CatRepo.GetByIsDeleted(false), i => i.Title, i => i.Id);
            else
                NewComboBox(i => i.ProductCategoryId, "عنوان دسته بندی", CatRepo.GetById(CatId), i => i.Title,
                     i => i.Id);


            NewTextBox(i => i.Title, "عنوان");
            NewTextBox(i => i.Key, "کلید");
            NewTextBox(i => i.Description, "توضیحات", true);
            ArrangementControls();

        }
    }
}
