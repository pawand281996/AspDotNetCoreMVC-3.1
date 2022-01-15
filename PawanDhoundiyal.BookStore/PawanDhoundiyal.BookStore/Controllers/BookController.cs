using Microsoft.AspNetCore.Mvc;
using PawanDhoundiyal.BookStore.Models;
using PawanDhoundiyal.BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawanDhoundiyal.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepository= null;

        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= _bookrepository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookrepository.GetBookid(id);
        }

        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return _bookrepository.SearchBook(bookName, authorName);
        }
    }
}
