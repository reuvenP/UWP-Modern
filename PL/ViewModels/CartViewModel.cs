using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace PL.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        public CartViewModel(ObservableCollection<Book> cart)
        {
            Cart = cart;
            SelectedBooks = new ObservableCollection<Book>();
            RemoveFromCartCMD = new DelegateCommand(RemoveFromCart);
        }

        private ObservableCollection<Book> _cart;
        public ObservableCollection<Book> Cart
        {
            get
            {
                return _cart;
            }

            set
            {
                _cart = value;
                OnPropertyChanged("Cart");
            }
        }

        private ObservableCollection<Book> _selectedBooks;
        public ObservableCollection<Book> SelectedBooks
        {
            get
            {
                return _selectedBooks;
            }

            set
            {
                _selectedBooks = value;
                OnPropertyChanged("SelectedBooks");
            }
        }

        public DelegateCommand RemoveFromCartCMD
        {
            get
            {
                return _removeFromCartCMD;
            }

            set
            {
                _removeFromCartCMD = value;
                OnPropertyChanged("RemoveFromCartCMD");
            }
        }

        public Book SelectedBook
        {
            get
            {
                return _selectedBook;
            }

            set
            {
                _selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public void RemoveFromCart(object obj)
        {
            /*if (SelectedBooks == null)
                return;
            foreach (var selectedBook in SelectedBooks)
            {
                Cart.Remove(selectedBook);
            }*/
            if (SelectedBook != null)
                Cart.Remove(SelectedBook);
        }

        private DelegateCommand _removeFromCartCMD;

        private Book _selectedBook;
    }
}
