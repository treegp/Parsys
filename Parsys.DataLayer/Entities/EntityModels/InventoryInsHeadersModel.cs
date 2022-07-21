using System;
namespace Parsys.DataLayer.Entities.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class InventoryInsHeaders
    {
        [GenericRepoModel.Column(true,true, true)]
        public long Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int InventoryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Title { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Description { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime Date { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool Accepted { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> AcceptDate { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> AcceptedByUserId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDeleted { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> DeleteDate { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> DeleteByUserId { get; set; }

    }
}
