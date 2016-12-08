using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    /// <summary>
    /// class to implemnt IRepository interface for UserRepository
    /// </summary>
    public class UserRepository : IRepository<User>
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public UserRepository()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("Mivchar_project");
        }

        /// <summary>
        /// delete User from DB
        /// </summary>
        /// <param name="entity">User object</param>
        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// return all the Users as list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// return all Users that fulfill the conditions
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public IEnumerable<User> GetAllByCondition(Predicate<User> condition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// return User by ID
        /// </summary>
        /// <param name="id">id number</param>
        /// <returns></returns>
        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// svae the User to the DB
        /// </summary>
        /// <param name="entity">User Object</param>
        public void Save(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// update the User in DB
        /// </summary>
        /// <param name="entity">Book Object</param>
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
