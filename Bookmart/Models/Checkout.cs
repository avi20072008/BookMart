using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookmart.Models
{
    public class Checkout
    {
        public int Id { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public Subscriber Subscriber { get; set; }

        public DateTime DateCheckout { get; set; }
        public DateTime? DateCheckIn { get; set; }

    }
}