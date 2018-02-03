using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace MyBooksApp.Models
{
    class Rating : RealmObject
    {
        public int Number { get; set; }
        public String Description { get; set; }
    }
}
