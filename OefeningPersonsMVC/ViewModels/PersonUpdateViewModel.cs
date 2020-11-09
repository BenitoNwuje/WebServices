using OefeningPersonsMVC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OefeningPersonsMVC.ViewModels
{
    public class PersonUpdateViewModel
    {
        [Required, MaxLength(80)]
        public string FirstName { get; set; }
        [Required, MaxLength(80)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
    }
}
