using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MongoDB.Driver;

namespace DAL
{
    /// <summary>
    /// interface for repository for BookRepository and UserRepository
    /// </summary>
    /// <typeparam name="TEntity">Book or User</typeparam>
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// return Entity by ID
        /// </summary>
        /// <param name="id">id number</param>
        /// <returns></returns>
        TEntity GetById(string id);
        /// <summary>
        /// save the Entity
        /// </summary>
        /// <param name="entity"></param>
        void Save(TEntity entity);
        /// <summary>
        /// delete the Entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);
        /// <summary>
        /// update changes in the Entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// return list of all this Entityes
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// return list of all this Entityes by specific condition
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAllByCondition(Predicate<TEntity> condition);
    }
}
