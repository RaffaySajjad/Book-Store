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
                new BookModel(){Id=1, Author="Elif Shafaq", Title="Forty Rules of Love", Description="The pursuit for God"},
                new BookModel(){Id=2, Author="Stephen Hawkings", Title="The Grand Design", Description="Scientific view of the creation of universe"},
                new BookModel(){Id=3, Author="Raffay Sajjad", Title="MVC", Description="Basics of Model View Controller, Design Hierarchy"},
                new BookModel(){Id=4, Author="Author", Title="ASP.Net", Description="Web Development using modern web tools"},
                new BookModel(){Id=5, Author="Hassan", Title="Cloud Computing", Description="A dive into new computing field"},
                new BookModel(){Id=5, Author="Muddassir", Title="Microsoft Azure", Description="Expand you business capabilities with leveraging Microsoft's servers"},
                new BookModel(){Id=5, Author="Raffay Sajjad", Title="Microsoft SQL", Description="Get to know one of the most popular RDBMS"},
                new BookModel(){Id=5, Author="Abeya", Title="Xcode", Description="Unlock the capabilities of Apple's ecosystem"},
                new BookModel(){Id=5, Author="Mahnoor", Title="Swift", Description="Make apps for macOS, iOS, tvOS, watchOS"}
            };
        }
    }
}
