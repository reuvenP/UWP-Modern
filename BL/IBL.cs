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
    /// interface of BL layer
    /// </summary>
    public interface IBL
    {
        /// <summary>
        /// return book list by Title
        /// </summary>
        /// <param name="title">Title name</param>
        /// <returns></returns>
        List<Book> GetBooksByTitle(string title);
        /// <summary>
        /// return book list by Author
        /// </summary>
        /// <param name="author">Author name</param>
        /// <returns></returns>
        List<Book> GetBooksByAuthor(string author);
        /// <summary>
        /// return all the books as list
        /// </summary>
        /// <returns></returns>
        IEnumerable<Book> GetAllBooks();
        /// <summary>
        /// return book by ID
        /// </summary>
        /// <param name="id">Book ID</param>
        /// <returns></returns>
        Book GetBookById(string id);
        /// <summary>
        /// submit the order by writting it to xml file
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="shipAddress"></param>
        void SubmitOrder(List<Book> shoppingCart, string name, string email, string phone, string shipAddress);
    }
}
