using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookmart.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string SubscriptionType { get; set; }
        public int Discount { get; set; }
    }
}