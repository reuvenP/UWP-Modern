using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MongoDB.Driver;

namespace DAL
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(string id);
        void Save(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllByCondition(Predicate<TEntity> condition);
    }
}
