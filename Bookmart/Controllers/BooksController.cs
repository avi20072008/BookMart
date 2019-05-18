using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Bookmart.Models;
using Bookmart.ViewModel;

namespace Bookmart.Controllers
{
    public class BooksController : Controller
    {
        ApplicationDbContext _context;
        
        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Books
        public ActionResult Index()
        {

            var books = _context.Book.ToList();
            var genres = _context.Genre.ToList();

            var viewModel = new BookGenreViewModel()
            {
                books = books,
                genres = genres
            };

            if (User.IsInRole("Admin"))
            {
                return View("Index", viewModel);
            }
            else
            { 
                return View("ReadOnlyList", viewModel);
            }
        }

        public ActionResult Edit(int id)
        {
            var book = _context.Book.SingleOrDefault(b => b.Id == id);
            var genres = _context.Genre.ToList();
            var viewModel = new BookEditViewModel()
            {
                Book = book,
                genres = genres
            };

            return View(viewModel);
        }

        public ActionResult Save(Book book)
        {
            if (ModelState.IsValid)
            {
                var bookInDB = _context.Book.SingleOrDefault(s => s.Id == book.Id);

                if (bookInDB == null)
                    return RedirectToAction("Index", "Books");

                bookInDB.Name = book.Name;
                bookInDB.GenreId = book.GenreId;

                _context.SaveChanges();
                return RedirectToAction("Index", "Books");

            } else
            {
                var bookRecord = _context.Book.SingleOrDefault(b => b.Id == book.Id);
                var genres = _context.Genre.ToList();
                var viewModel = new BookEditViewModel()
                {
                    Book = bookRecord,
                    genres = genres
                };
                return View("Edit", viewModel);
            }
        }
    }
}
