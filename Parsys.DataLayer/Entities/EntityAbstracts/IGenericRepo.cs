using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IGenericRepo<TEntity>

    {
        int Insert(TEntity entity);
        int Delete(TEntity entity);
        int Update(TEntity entity);
        List<TEntity> GetAll();
        TEntity Top();
        int Count();
    }
}
