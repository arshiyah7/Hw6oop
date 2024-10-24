using Hw6oop.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6oop.Entity
{
    public class LibraryServices : ILibraryService
    {
        public void BorrowBook(string name)
        {
            Member m1 = new Member("0");
            foreach (Book book in Storage.books)
            {
                Book b = new Book(book.BookId, book.Name);

                if (book is not null)
                {
                    Console.WriteLine(book.Name + "," + book.BookId + "\n");
                }

                if (book is not null)
                {

                    if (book.Name == name)
                    {
                        book.BookId = m1.UserId;
                        break;
                    }


                }

            }
        }

        public void GetListOfLibraryBooks()
        {

            foreach (Book book in Storage.books)
            {
                Member m1 = new Member("0");
                if (book is not null)
                {

                    if (book.BookId != m1.UserId)
                    {
                        Console.WriteLine("list of book is :");
                    }

                }

            }

           


        }

        public void GetListOfUserBooks()
        {
            foreach (Book book in Storage.books)
            {
            
                if (book is not null)
                {
                    Member m1 = new Member("0");
                    if (book.BookId == m1.UserId)
                    {
                        Console.WriteLine("list of your book is:" + book.Name);
                    }


                }



            }
        }

        public void ReturnBook(string name1)
        {
            foreach(Book book in Storage.books)
            {
                Member m1 = new Member("0");
                if (book.Name == name1 && book.BookId ==m1.UserId)
                {
                    book.BookId = book.BookId;
                    Console.WriteLine("successful");
                }
            }
        }
    }

    
}

