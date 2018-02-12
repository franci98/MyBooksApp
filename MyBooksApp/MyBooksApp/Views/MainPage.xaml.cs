using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyBooksApp.ViewModels;
using MyBooksApp.Models;

namespace MyBooksApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                throw;
            }
            
            BindingContext = new MainViewModel(this.Navigation);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as MainViewModel;
            Book SelectedBook = e.Item as Book;

            vm.BookDetailsCommand.Execute(SelectedBook);
        }
    }
}
