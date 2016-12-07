using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public interface IBL
    {
        List<Book> GetBooksByTitle(string title);
        List<Book> GetBooksByAuthor(string author);
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(string id);
        void SubmitOrder(List<Book> shoppingCart, string name, string email, string phone, string shipAddress);
    }
}
