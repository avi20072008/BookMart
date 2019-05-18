using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bookmart.Models;

namespace Bookmart.Controllers.Api
{
    public class BooksController : ApiController
    {
        ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Book.ToList();
        }
    }
}
