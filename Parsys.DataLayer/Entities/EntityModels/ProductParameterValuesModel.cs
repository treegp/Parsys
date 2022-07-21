using System;
namespace Parsys.DataLayer.Entities.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ProductParameterValues
    {
        [GenericRepoModel.Column(true,false,true)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,true)]
        public int ProductParameterId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Value { get; set; }

    }
}
