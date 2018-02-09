using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Realms;
using MyBooksApp.Models;
using Xamarin.Forms;

namespace MyBooksApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        #region Fields
        private Realm _realmObject;
        private Rating _selectedRating;
        private List<Rating> _ratings;
        private String _bookName;

        #endregion

        #region Properties

        public String BookName
        {
            get { return _bookName; }
            set {
                _bookName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("BookName"));
            }
        }

        public List<Rating> Ratings
        {
            get { return _ratings; }
            set {
                _ratings = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Ratings"));
            }
        }

        public Rating SelectedRating
        {
            get { return _selectedRating; }
            set {
                _selectedRating = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedRating"));
            }
        }

        public Command AddBookCommand {
            get { return new Command(AddBook); }
        }

        #endregion

        #region Constructors

        public MainViewModel()
        {
            _realmObject = Realm.GetInstance();
            _ratings = _realmObject.All<Rating>().ToList();

            if (_ratings.Count == 0) {
                _realmObject.Write(() =>
                {
                    _realmObject.Add<Rating>(new Rating { Number = 1, Description = "Bad book" });
                    _realmObject.Add<Rating>(new Rating { Number = 2, Description = "Good book" });
                    _realmObject.Add<Rating>(new Rating { Number = 3, Description = "Great book" });
                });
                _ratings = _realmObject.All<Rating>().ToList();
            }

        }

        #endregion

        #region Methods
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddBook()
        {
            _realmObject.Write(() =>
            {
                _realmObject.Add<Book>(new Book() { DisplayName = _bookName, BookRating = _selectedRating });
            });
            
        }

        #endregion

    }
}
