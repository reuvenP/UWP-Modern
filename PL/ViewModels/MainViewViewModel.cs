using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using MongoDB.Bson;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace PL.ViewModels
{
    public class MainViewViewModel : BaseViewModel
    {
        private ICollectionView _booksView;
        public ICollectionView BookView
        {
            get { return _booksView; }
        }

        private ObservableCollection<Book> _books;
        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set
            {
                _books = value;
                OnPropertyChanged("Books");
            }
        }

        private string _searchLine;
        public string SearchLine
        {
            get { return _searchLine; }
            set
            {
                _searchLine = value;
                _booksView.Refresh();
                OnPropertyChanged("SearchLine");
            }
        }

        private bool _isFilterByTitle;
        public bool IsFilterByTitle
        {
            get { return _isFilterByTitle; }
            set
            {
                _isFilterByTitle = value;
                OnPropertyChanged("IsFilterByTitle");
                _booksView.Refresh();
            }
        }
        public bool IsFilterByAuthor
        {
            get { return !_isFilterByTitle; }
            set
            {
                _isFilterByTitle = !value;
                OnPropertyChanged("IsFilterByAuthor");
                _booksView.Refresh();
            }
        }

        private bool filter(object obj)
        {
            if (String.IsNullOrEmpty(SearchLine))
                return true;
            var book = obj as Book;
            if (IsFilterByAuthor)
            {
                if (book.Author.Contains(SearchLine))
                    return true;
            }
            else if (IsFilterByTitle)
            {
                if (book.Title.Contains(SearchLine))
                    return true;
            }
            return false;
        }

        private Book _selectedBook;
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged("SelectedBook");
                if (_selectedBook == null)
                    IsSelectedBook = false;
                else
                    IsSelectedBook = true;
            }
        }

        private bool _isSelectedBook;
        public bool IsSelectedBook
        {
            get { return _isSelectedBook; }
            set
            {
                _isSelectedBook = value;
                OnPropertyChanged("IsSelectedBook");
            }
        }

        private readonly object _booksLock = new object();

        public MainViewViewModel(IBL bl_adapter)
        {
            _books = new ObservableCollection<Book>(bl_adapter.GetAllBooks());
            _booksView = CollectionViewSource.GetDefaultView(_books);
            _booksView.Filter = filter;
            BindingOperations.EnableCollectionSynchronization(Books, _booksLock);
            IsFilterByTitle = true;
        }
    }
}
