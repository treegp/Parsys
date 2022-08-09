using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IGenericRepo<TEntity>

    {
        TEntity Insert(TEntity entity);
        int Delete(TEntity entity);
        TEntity Update(TEntity entity);
        List<TEntity> GetAll();
        TEntity Top();
        int Count();
    }
}
