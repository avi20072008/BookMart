using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bookmart.Models;

namespace Bookmart.Controllers.Api
{
    public class SubsController : ApiController
    {
        ApplicationDbContext _context;

        public SubsController()
        {
            _context = new ApplicationDbContext();

        }

        [Route("api/subs/search/{q:alpha}")]
        [HttpGet]
        public IEnumerable<Subscriber> search(string q)
        {
            //return _context.Subscriber.SqlQuery("Select * from Subscribers Where Name like '%q%'").ToList();
            var subs = from s in _context.Subscriber
                          where s.Name.Contains(q)
                          select s;

            return subs;
        }
        [HttpGet]
        public IEnumerable<Subscriber> GetSubs()
        {
            return _context.Subscriber.ToList();
        }
        [HttpGet]
        public Subscriber GetSub(int id)
        {
            return _context.Subscriber.SingleOrDefault(s=>s.Id == id);
        }

    }
}
