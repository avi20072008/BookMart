using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bookmart.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Book Name is required.")]
        [StringLength(100)]
        public string  Name { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage ="Please select Book Genre")]
        public int GenreId { get; set; }
    }
}