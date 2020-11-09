using HelloCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.ViewModels
{
    public class RestaurantCreateViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
