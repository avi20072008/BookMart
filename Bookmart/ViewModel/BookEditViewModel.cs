using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookmart.Models;

namespace Bookmart.ViewModel
{
    public class BookEditViewModel
    {
        public Book Book { get; set; }
        public List<Genre> genres { get; set; }
    }
}