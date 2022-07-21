using System;
namespace Parsys.DataLayer.Entities.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Users
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string UserName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsDeleted { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<DateTime> DeleteDate { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> DeleteByUserId { get; set; }

    }
}
