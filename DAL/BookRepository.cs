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
    /// <summary>
    /// class to implemnt IRepository interface for BookRepository
    /// </summary>
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

        /// <summary>
        /// delete Book from DB
        /// </summary>
        /// <param name="entity">Book object</param>
        public void Delete(Book entity)
        {
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("Id", entity.Id);
            var book = collection.DeleteOne(filter);
        }

        /// <summary>
        /// return all the Books as list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetAll()
        {
            var collection = _database.GetCollection<Book>("Books");
            var books = collection.Find(_ => true).ToEnumerable();
            return books;
        }

        /// <summary>
        /// return all Books that fulfill the conditions
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public IEnumerable<Book> GetAllByCondition(Predicate<Book> condition)
        {
            var allBooks = this.GetAll();
            return allBooks.Where(x => condition(x));
        }


        /// <summary>
        /// return Book by ID
        /// </summary>
        /// <param name="id">id number</param>
        /// <returns></returns>
        public Book GetById(string id)
        {
            var obId = ObjectId.Parse(id);
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("Id", obId);
            var book = collection.Find(filter).FirstOrDefault();
            return book;
        }

        /// <summary>
        /// svae the Book to the DB
        /// </summary>
        /// <param name="entity">Book Object</param>
        public void Save(Book entity)
        {
            var collection = _database.GetCollection<Book>("Books");
            collection.InsertOne(entity);
        }

        /// <summary>
        /// update the Book in DB
        /// </summary>
        /// <param name="entity">Book Object</param>
        public void Update(Book entity)
        {
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("Id", entity.Id);
            collection.FindOneAndReplace(filter, entity);
        }


        /// <summary>
        /// insert images first time
        /// </summary>
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
