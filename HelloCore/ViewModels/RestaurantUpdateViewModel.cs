using HelloCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.ViewModels
{
    public class RestaurantUpdateViewModel
    {
        [Required, MaxLength(80)] //dit wilt zeggen dat je moet geven met maximum 80 characters
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
