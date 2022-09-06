﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Models
{
    internal class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishedOn { get; set;}

        public decimal Price { get; set; }

        public DateTime ImageUrl { get; set; }

    }
}
