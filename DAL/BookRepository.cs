using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.IO;

namespace DAL
{
    public sealed class BookRepository : IRepository<Book>
    {
        //
        private static readonly BookRepository instance = new BookRepository();
        static BookRepository() { }
        private BookRepository()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("Mivchar_project");
            //insertImages();
        }
        public static BookRepository Insatnce { get { return instance; } }
        //
        private static IMongoClient _client;
        private static IMongoDatabase _database;

        public void Delete(Book entity)
        {
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("Id", entity.Id);
            var book = collection.DeleteOne(filter);
        }

        public IEnumerable<Book> GetAll()
        {
            var collection = _database.GetCollection<Book>("Books");
            var books = collection.Find(_ => true).ToEnumerable();
            return books;
        }

        public IEnumerable<Book> GetAllByCondition(Predicate<Book> condition)
        {
            var allBooks = this.GetAll();
            return allBooks.Where(x => condition(x));
        }

        public Book GetById(string id)
        {
            var obId = ObjectId.Parse(id);
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("Id", obId);
            var book = collection.Find(filter).FirstOrDefault();
            return book;
        }

        public void Save(Book entity)
        {
            var collection = _database.GetCollection<Book>("Books");
            collection.InsertOne(entity);
        }

        public void Update(Book entity)
        {
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("Id", entity.Id);
            collection.FindOneAndReplace(filter, entity);
        }

        //insert images first time
        public void insertImages()
        {
            string path = @"C:\Code\images";
            var files = Directory.GetFiles(path);
            var books = this.GetAll();
            var numOfFiles = files.Count();
            int i = 0;
            var collection = _database.GetCollection<Book>("Books");
            var newCol = _database.GetCollection<Book>("Booksim");
            foreach (var book in books)
            {
                book.Image = File.ReadAllBytes(files[i++]);
                newCol.InsertOne(book);
                if (i == numOfFiles - 1)
                    i = 0;
            }
            
        }
        //-------------------------
    }
}
