using PawanDhoundiyal.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawanDhoundiyal.BookStore.Repository
{
    //where we can get the data from data source
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return dataSource();
        } 
        
        public BookModel GetBookid(int id)
        {
            return dataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return dataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> dataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC" ,Author="Pawan",Description="this is description of first Book"},
                new BookModel(){Id=1, Title="Java" ,Author="Shivani",Description="this is description of Second Book"},
                new BookModel(){Id=1, Title="c++" ,Author="Prabhat",Description="this is description of Third Book"},
                 new BookModel(){Id=1, Title="php" ,Author="Nitu",Description="this is description of Fifth Book"},
            };
        }
    }
}
