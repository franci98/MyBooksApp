using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBooksApp.Models;
using System.ComponentModel;

namespace MyBooksApp.ViewModels
{
    public class BookDetailsViewModel : INotifyPropertyChanged
    {
        private Book _selectedBook;

        
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { _selectedBook = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedBook")); }
        }

        public BookDetailsViewModel(Book selectedBook)
        {
            this._selectedBook = selectedBook;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
