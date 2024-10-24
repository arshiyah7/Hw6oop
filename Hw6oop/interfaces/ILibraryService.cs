using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6oop.interfaces
{
    public interface ILibraryService
    {

        public void BorrowBook(string name);
        public void ReturnBook(string name1);
        public void GetListOfLibraryBooks();
        public void GetListOfUserBooks();
    }
}
