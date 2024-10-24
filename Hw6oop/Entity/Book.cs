using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6oop.Entity
{
    public class Book
    {
        public Book(string bookid , string name)
        {
            this.Name = name;
            this.BookId = bookid;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string BookId { get; set; }


    }
}
