using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookmart.Models
{
    public class Subscriber
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is a required field")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Date Of Birth is a required field")]
        [Display(Name="Date Of Birth")]
        [AgeCheckValidation]
        public DateTime BirthDate { get; set; }

        public Subscription Subscription { get; set; }
        public int SubscriptionId { get; set; }

    }
}