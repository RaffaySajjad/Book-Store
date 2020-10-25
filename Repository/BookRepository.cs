using Book_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id=1, Author="Stephen Hawkings", Title="The Grand Design"},
                new BookModel(){Id=2, Author="Elif Shafaq", Title="Forty Rules of Love"},
                new BookModel(){Id=3, Author="Raffay Sajjad", Title="MVC"},
                new BookModel(){Id=4, Author="Author", Title="ASP.Net"},
                new BookModel(){Id=5, Author="Author", Title="Visual Studio"}
            };
        }
    }
}
