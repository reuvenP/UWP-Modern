using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Windows;
using System.IO;
using System.Xml.Linq;
using System.Net.Mail;

namespace PL.ViewModels
{
    public class SubmitViewModel : BaseViewModel
    {
        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public ObservableCollection<Book> Cart { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
                OnPropertyChanged("Mail");
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public DelegateCommand SubmitCMD
        {
            get
            {
                return _submitCMD;
            }

            set
            {
                _submitCMD = value;
                OnPropertyChanged("SubmitCMD");
            }
        }

        public SubmitViewModel(ObservableCollection<Book> cart, Controller controller)
        {
            Cart = cart;
            SubmitCMD = new DelegateCommand(submitOrder);
            ParentInstance = controller;
        }

        public Controller ParentInstance { get; set; }

        private string _name;
        private string _address;
        private string _mail;
        private string _phone;
        private DelegateCommand _submitCMD;

        public void submitOrder(object obj)
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Address) || String.IsNullOrEmpty(Mail) || String.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!IsValidEmail(Mail))
            {
                MessageBox.Show("Mail address is invalid", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            XElement orders = new XElement("orders");
            if (!File.Exists(@"orders.xml"))
                orders.Save(@"orders.xml");
            else
                orders = XElement.Load(@"orders.xml");
            XElement order = new XElement("order");
            order.Add(new XElement("name", Name));
            order.Add(new XElement("address", Address));
            order.Add(new XElement("mail", Mail));
            order.Add(new XElement("phone", Phone));
            XElement books = new XElement("books");
            var booksCollection = (from b in Cart
                                   select new XElement("book", new XElement("title", b.Title), new XElement("author", b.Author), new XElement("pages", b.Pages), new XElement("year", b.YearPublication))
                                   ).ToArray();
            books.Add(booksCollection);
            order.Add(books);
            orders.Add(order);
            orders.Save(@"orders.xml");
            MessageBox.Show("Order Submitted!");
            Cart.Clear();
            ParentInstance.PostSubmit(new object { });
        }
    }
}
