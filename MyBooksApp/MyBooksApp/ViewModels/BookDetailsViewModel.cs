using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBooksApp.Models;
using System.ComponentModel;
using Xamarin.Forms;
using Realms;

namespace MyBooksApp.ViewModels
{
    public class BookDetailsViewModel : INotifyPropertyChanged
    {

        #region Fields
        private Book _selectedBook;
        private Realm _realmObject;
        private INavigation _navigation;
        #endregion
                
        public Command DeleteBookCommand
        {
            get { return new Command(DeleteBook) ; }
        }

        private void DeleteBook(object obj)
        {
            _realmObject.Write(() =>
            {
                _realmObject.Remove(SelectedBook);
            });
            _navigation.PopAsync();
        }


        #region Properties
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedBook"));
            }
        }

        #endregion

        #region Constructors
        public BookDetailsViewModel(Book selectedBook, INavigation navigation)
        {
            this._selectedBook = selectedBook;
            _navigation = navigation;
            _realmObject = Realm.GetInstance();
        }

        #endregion

        #region Methods
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
