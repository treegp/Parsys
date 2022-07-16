using System;
namespace Parsys.DataLayer
{
    [Table("dbo")]
    public class ProductParameterValues
    {
        [Column(true,false,true)]
        public int ProductId { get; set; }

        [Column(true,false,true)]
        public int ProductParameterId { get; set; }

        [Column(false,false,false)]
        public string Value { get; set; }

    }
}
