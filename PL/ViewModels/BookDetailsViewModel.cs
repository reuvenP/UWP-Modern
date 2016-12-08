using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace PL.ViewModels
{
    /// <summary>
    /// class to connect the model to the view this class Inherited from BaseViewModel that Inherited from INotifyPropertyChanged
    /// </summary>
    public class BookDetailsViewModel : BaseViewModel
    {
        private Book _selectedBook;
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }
    }
}
