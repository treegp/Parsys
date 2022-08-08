using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.InventoryForms
{
    public class Editor : EntityEditorClass<Inventories>
    {
        private DataLayer.Connections.ProviderMethods.ConnectToSQL con = new DataLayer.Connections.ProviderMethods.ConnectToSQL();
        private CorporationsRepository corpRepo;

        public Editor()
        {

            Id = "EditInventories";
            MultipleInstance = false;
            Title = "";
            corpRepo = new CorporationsRepository(con.GetConnection());

        }

        protected override void OnLoad(EventArgs e)
        {
            newTextBox(entity => entity.Title, "عنوان انبار");
            newComboBox(entity => entity.CorporationId, "شرکت/سازمان", corpRepo.GetAll(), s => s.Title, i => i.Id);
            newTextBox(entity => entity.Description, "توضیحات");

            base.OnLoad(e);
        }
    }
}
