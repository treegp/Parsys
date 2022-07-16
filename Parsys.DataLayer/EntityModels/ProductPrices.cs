using System;
namespace Parsys.DataLayer
{
    [Table("dbo")]
    public class ProductPrices
    {
        [Column(true,true,true)]
        public int Id { get; set; }

        [Column(true,false,false)]
        public int ProductId { get; set; }

        [Column(true,false,false)]
        public DateTime Date { get; set; }

        [Column(true,false,false)]
        public decimal Price { get; set; }

    }
}
