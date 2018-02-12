using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBooksApp.Views
{
	public partial class BookDetailsPage : ContentPage
	{
		public BookDetailsPage (Models.Book selectedBook)
		{
            InitializeComponent();
            BindingContext = new ViewModels.BookDetailsViewModel(selectedBook);
		}
	}
}