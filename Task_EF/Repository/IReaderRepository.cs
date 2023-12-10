using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF.Repository
{
    public interface IReaderRepository<TKey, TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity? Get(TKey id);
    }
}
