using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2.Models
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager 
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author="Futurum",CoverImage="Assets/book1.jpg" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequirte Que", CoverImage = "Assets/book2.jpg" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/book3.jpg" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "option", CoverImage = "Assets/book4.jpg" });
            books.Add(new Book { BookId = 5, Title = "Feugait", Author = "Acumsan", CoverImage = "Assets/book2.jpg" });
            books.Add(new Book { BookId = 6, Title = "Nostrud", Author = "Legunt", CoverImage = "Assets/book3.jpg" });
            books.Add(new Book { BookId = 7, Title = "Decima", Author = "Jack", CoverImage = "Assets/book1.jpg" });
            books.Add(new Book { BookId = 8, Title = "Aliquip", Author = "Magna", CoverImage = "Assets/book4.jpg" });

            return books;
        }
    }
}
