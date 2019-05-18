using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookmart.Models;

namespace Bookmart.ViewModel
{
    public class NewSubscriberViewModel
    {
        public Subscriber subscriber { get; set; }
        public List<Subscription> subscriptions { get; set; }
    }
}