using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Bookmart.Dtsos;
using Bookmart.Models;

namespace Bookmart.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateCheckout(CheckoutDto newCheckout)
        {
            // Get the subscriber who is checking out the books
            var sub = _context.Subscriber.Single(s => s.Id == newCheckout.SubId);

            // Get all the books selected during checkout. This SQL will be as -
            // SELECT * From Books Where Id IN ( 3, 4, 5, 8);  // 3,4,5,8 are bookids during checkout.
            var books = _context.Book.Where(b=>newCheckout.BookIds.Contains(b.Id));

            foreach (var b in books)
            {
                // create checkout object for each book
                var objCheckout = new Checkout
                {
                    Subscriber = sub,
                    Book = b,
                    DateCheckout = DateTime.Now
                };

                // Add checked out books details in the Checkout Model
                _context.Checkouts.Add(objCheckout);
            }

            // after checkout is complete, save all entries in the database.
            _context.SaveChanges();

            throw new NotImplementedException();
        }

    }
}
