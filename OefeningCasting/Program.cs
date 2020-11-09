using System;

namespace OefeningCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new object[4];
            shapes[0] = new Dot(5, 7);
            shapes[1] = new Square(5);
            shapes[2] = new Circle(2);
            shapes[3] = new Square(8);

            foreach (var shape in shapes)
            {
                Dot dot = shape as Dot; //gaat zien of deze dot well deze type is als die niet die type is geeft my een null terug
                if (dot != null)
                {
                    Console.WriteLine($"Punt: ({dot.X} {dot.Y})");
                }

                Square vierkant = shape as Square;
                if (vierkant != null)
                {
                    Console.WriteLine($"Vierkant: Omtrek: {vierkant.Perimeter}");
                }

                Circle cirkel = shape as Circle;
                if (cirkel != null)
                {
                    Console.WriteLine($"Cirkel: Oppervlakte: {cirkel.Area}");
                }

                





            }
        }
    }
}
