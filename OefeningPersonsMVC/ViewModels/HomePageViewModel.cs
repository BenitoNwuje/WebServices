using OefeningPersonsMVC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OefeningPersonsMVC.ViewModels
{
    public class HomePageViewModel
    {
        [Required, MaxLength(80)]
        public string CurrentMessage { get; set; }
        public IEnumerable<Person> Person { get; set; }
    }
}
