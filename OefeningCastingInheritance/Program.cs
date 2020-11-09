using System;
using System.Collections.Generic;

namespace OefeningCastingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var Buildings = new List<Building>
            {
                new Restaurant
                {
                    City = "Gent",
                    CuisineType = CuisineType.French,
                    NumberOfTables = 10,
                    Street = "Sint-Baafsplein 5"
                },
                new Shop {City = "Antwerpen", Street = "Meir 32", HasWebshop = true},
                new Pool {City = "Antwerpen", Street = "Desguinlei 17", WaterTemperature = 28.5},
                new Shop {City = "Brussel", Street = "Nieuwstraat 3"},
            };
            foreach (var gebouw in Buildings)
            {
                Restaurant eethuis = gebouw as Restaurant;
                if (eethuis != null)
                {
                    Console.WriteLine($"Het adres van het gebouw is: {eethuis.Street}, {eethuis.City} ");
                    Console.WriteLine($"Het restaurant heeft: {eethuis.NumberOfTables} tafels");
                    Console.WriteLine($"Het keuken type is: {eethuis.CuisineType} ");
                    Console.WriteLine();
                }
                Shop winkel = gebouw as Shop;
                if (winkel != null)
                {
                    Console.WriteLine($"Het adres van het gebouw is: {winkel.Street}, {winkel.City} ");
                    if (winkel.HasWebshop)
                    {
                        Console.WriteLine("De winkel heeft een webshop");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("De winkel heeft geen webshop");
                        Console.WriteLine();
                    }
                }
                Pool zwembad = gebouw as Pool;
                if (zwembad != null)
                {
                    Console.WriteLine($"Het adres van het gebouw is: {zwembad.Street}, {zwembad.City} ");
                    Console.WriteLine($"De temperatuur van het water is: {zwembad.WaterTemperature}");
                    Console.WriteLine();

                }



            }
        }
    }
}
