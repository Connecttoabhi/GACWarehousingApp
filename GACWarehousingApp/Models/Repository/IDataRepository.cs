using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models.Repository
{
    public interface IDataRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
