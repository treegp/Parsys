﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.WinClient.Views.Framework;

namespace Parsys.WinClient.Views.InventoryForms
{
    

    public partial class List : ViewBaseControl
    {
        private IInventoriesRepository invRepo;
        public List(IInventoriesRepository repo)
        {
            InitializeComponent();
            invRepo = repo;
        }


        protected override void OnLoad(EventArgs e)
        {
            var grid = new GridHandler<DataLayer.Entities.EntityModels.Inventories>(this, invRepo.GetAll());

            grid.AddStringColumn(i => i.Id,"شناسع");
            grid.AddStringColumn(i => i.CorporationId,"شناسه شرکت");
            grid.AddStringColumn(i => i.Title,"عنوان");
            grid.AddStringColumn(i => i.Description);
            grid.AddStringColumn(i => i.IsDeleted);
            


            base.OnLoad(e);
        }
    }
}