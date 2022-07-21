using System;
namespace Parsys.DataLayer.Entities.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class FinancialYears
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int CorporationId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Title { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Description { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime StartDate { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime FinishDate { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsClosed { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> CloseDate { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ClosedByUserId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDeleted { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> DeleteDate { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> DeleteByUserId { get; set; }

    }
}
