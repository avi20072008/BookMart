using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookmart.Dtsos;

namespace Bookmart.Dtsos
{
    public class CheckoutDto
    {
        public int SubId { get; set; }
        public List<int> BookIds { get; set; }
    }
}