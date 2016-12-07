using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
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

        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepo.GetAll();
        }

        //
        public Book GetBookById(string id)
        {
            return bookRepo.GetById(id);
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return bookRepo.GetAllByCondition(x => x.Author.Contains(author)).ToList();
        }

        public List<Book> GetBooksByTitle(string title)
        {
            return bookRepo.GetAllByCondition(x => x.Title.Contains(title)).ToList();
        }

        public void SubmitOrder(List<Book> shoppingCart, string name, string email, string phone, string shipAddress)
        {
            throw new NotImplementedException();
        }
    }
}
