﻿using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;
using Parsys.WinClient.Views.Framework;
using System;

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
            NewComboBox(entity => entity.CorporationId, "شرکت/سازمان", corpRepo.GetAll(), s => s.Title, i => i.Id);
            NewTextBox(entity => entity.Title, "عنوان انبار");

            NewTextBox(entity => entity.Description, "توضیحات");
            ArrangementControls();
            base.OnLoad(e);
        }
    }
}
