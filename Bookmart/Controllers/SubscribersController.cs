using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookmart.Models;
using Bookmart.ViewModel;

namespace Bookmart.Controllers
{   
    [Authorize(Roles ="Admin")]
    public class SubscribersController : Controller
    {
        ApplicationDbContext _context;

        public SubscribersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Subscribers
        public ActionResult Index()
        {
            var subscribers = _context.Subscriber.ToList();
            var subscriptions = _context.Subscription.ToList();

            var viewModel = new SubscriberSubscriptionViewModel()
            {
                subscribers = subscribers,
                subscriptions = subscriptions
            };

            
            return View(viewModel);
        }

        // New Subscriber
        public ActionResult New()
        {
            var subscriptions = _context.Subscription.ToList();

            var viewModel = new NewSubscriberViewModel()
            {
                subscriptions = subscriptions
            };

            return View("New", viewModel);
        }

        // Save Subscriber
        [HttpPost]
        public ActionResult Save(Subscriber subscriber)
        {
            // if all validations are successful
            if(!ModelState.IsValid)
            {
                // if validation failed, go back to New Subscriber page.
                
                var viewModel = new NewSubscriberViewModel()
                {
                    subscriptions = _context.Subscription.ToList()
                };

                return View("New", viewModel);
            }
            else
            {
                // If subscriber is new.
                //if (sub.Id == 0)
               // {
                    _context.Subscriber.Add(subscriber);
                    _context.SaveChanges();
                //}

                return RedirectToAction("Index", "Subscribers");
            }
        }
    }
}