using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBooksApp.Models;

namespace MyBooksApp.ViewModels
{
    class BookDetailsViewModel
    {
        private Book selectedBook;

        public BookDetailsViewModel(Book selectedBook)
        {
            this.selectedBook = selectedBook;
        }
    }
}
