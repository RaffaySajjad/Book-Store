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
                new BookModel(){Id=1, Author="Elif Shafaq", Title="Forty Rules of Love", Description="The pursuit for God", Category="Literary fiction", Language="English", TotalPages=168 },
                new BookModel(){Id=2, Author="Stephen Hawkings", Title="The Grand Design", Description="Scientific view on the creation of universe", Category="Science", Language="English", TotalPages=750},
                new BookModel(){Id=3, Author="Raffay Sajjad", Title="MVC", Description="A modern design hierarchy", Category="Programming", Language="English", TotalPages=110},
                new BookModel(){Id=4, Author="Author", Title="ASP.Net", Description="Web Development using modern web tools", Category="Programming", Language="English", TotalPages=240},
                new BookModel(){Id=5, Author="Hassan", Title="Cloud Computing", Description="Leverage the power of cloud for a global outreach", Category="Programming", Language="English", TotalPages=350},
                new BookModel(){Id=6, Author="Muddassir", Title="Microsoft Azure", Description="Expand you business capabilities by leveraging Microsoft's servers", Category="Computer Science", Language="English", TotalPages=475},
                new BookModel(){Id=7, Author="Raffay Sajjad", Title="Microsoft SQL", Description="Get to know one of the most popular RDBMS", Category="Databases", Language="English", TotalPages=150},
                new BookModel(){Id=8, Author="Abeya", Title="Xcode", Description="Unlock the capabilities of Apple's ecosystem", Category="Programming", Language="English", TotalPages=240},
                new BookModel(){Id=9, Author="Mahnoor", Title="Swift", Description="Make apps for macOS, iOS, tvOS, watchOS", Category="Programming", Language="English", TotalPages=245}
            };
        }
    }
}
