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
    public class UserRepository : IRepository<User>
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public UserRepository()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("Mivchar_project");
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllByCondition(Predicate<User> condition)
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Save(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
