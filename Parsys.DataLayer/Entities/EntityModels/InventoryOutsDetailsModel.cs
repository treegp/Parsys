using System;
namespace Parsys.DataLayer.Entities.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class InventoryOutsDetails
    {
        [GenericRepoModel.Column(true,false,true)]
        public long InventoryOutsHeaderId { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Amount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal TotalPrice { get; set; }

    }
}
