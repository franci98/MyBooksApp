using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace MyBooksApp.Models
{
    public class Book : RealmObject
    {
        public String DisplayName { get; set; }
        public Rating BookRating { get; set; }
    }
}
