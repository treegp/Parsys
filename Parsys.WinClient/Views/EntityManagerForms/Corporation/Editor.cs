﻿using System;
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

namespace Parsys.WinClient.Views.EntityManagerForms.Corporation
{
    public partial class Editor : EntityEditorClass<Corporations>
    {
        public Parsys.DataLayer.Connections.ProviderMethods.ConnectToSQL con = new ConnectToSQL();
        public CorporationsRepository Repo;
        

        public Editor()
        {
            
            InitializeComponent();

            Repo = new CorporationsRepository(con.GetConnection());

            Title = "";
            Id = "CorporationsEditor";
            MultipleInstance = false;

            
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NewTextBox(i => i.Title, "عنوان");
            NewTextBox(i => i.Telephone, "تلفن");
            NewTextBox(i => i.Fax, "فکس");
            NewTextBox(i => i.Address, "آدرس",true);
            NewTextBox(i => i.Description, "توضیحات",true);
            ArrangementControls();

        }
    }
}
