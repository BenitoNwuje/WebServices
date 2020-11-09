using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.Entities
{
    public enum CuisineType
    {
        None,
        French,
        Italian,
        Japanses
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
