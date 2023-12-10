using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF.Repository
{
    public interface ICrudRepository<TKey, TEntity> : IReaderRepository<TKey, TEntity>
    {
        TKey Insert(TEntity entity);

        TKey Update(TKey id, TEntity entity);

        bool Delete(TEntity entity);
    }
}
