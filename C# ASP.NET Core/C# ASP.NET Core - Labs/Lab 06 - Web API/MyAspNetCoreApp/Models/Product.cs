using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ActiveFrom { get; set; }

        [Range(0, 10000)]
        public double Price { get; set; }

    }


}
