﻿using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        // navigation property for EF core
        public List<Product> Products { get; set; }


    }
}