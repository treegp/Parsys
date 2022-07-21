using System;
namespace Parsys.DataLayer.Entities.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductPrices
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime Date { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int Price { get; set; }

    }
}
