using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookmart.Models;

namespace Bookmart.ViewModel
{
    public class SubscriberSubscriptionViewModel
    {
        public List<Subscriber> subscribers { get; set; }
        public List<Subscription> subscriptions { get; set; }
    }
}