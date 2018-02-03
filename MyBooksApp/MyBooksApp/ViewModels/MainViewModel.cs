using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Realms;
namespace MyBooksApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        #region Fields
        private Realm _realmObject;
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



        #endregion

        #region Constructors

        public MainViewModel()
        {
            _realmObject = Realm.GetInstance();
        }

        #endregion

        #region Methods
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
