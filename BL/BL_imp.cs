using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    /// <summary>
    /// class to implemnt BL layer
    /// </summary>
    public sealed class BL_imp : IBL
    {
        private static IRepository<Book> bookRepo;
        private static readonly BL_imp instance = new BL_imp();
        static BL_imp() { }
        private BL_imp()
        {
            bookRepo = BookRepository.Insatnce;
        }
        public static BL_imp Insatnce { get { return instance; } }

        /// <summary>
        /// return all the books as list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepo.GetAll();
        }

        /// <summary>
        /// return book by ID
        /// </summary>
        /// <param name="id">Book ID</param>
        /// <returns></returns>
        public Book GetBookById(string id)
        {
            return bookRepo.GetById(id);
        }

        /// <summary>
        /// return book list by Author
        /// </summary>
        /// <param name="author">Author name</param>
        /// <returns></returns>
        public List<Book> GetBooksByAuthor(string author)
        {
            return bookRepo.GetAllByCondition(x => x.Author.Contains(author)).ToList();
        }

        /// <summary>
        /// return book list by Title
        /// </summary>
        /// <param name="title">Title name</param>
        /// <returns></returns>
        public List<Book> GetBooksByTitle(string title)
        {
            return bookRepo.GetAllByCondition(x => x.Title.Contains(title)).ToList();
        }

        /// <summary>
        /// submit the order by writting it to xml file
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="shipAddress"></param>
        public void SubmitOrder(List<Book> shoppingCart, string name, string email, string phone, string shipAddress)
        {
            throw new NotImplementedException();
        }
    }
}
