using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningCastingInheritance
{
    class Restaurant: Building
    {
        public CuisineType CuisineType { get; set; }
        public int NumberOfTables { get; set; }
    }
}
