using System;
using System.Collections.Generic;

namespace OefeningInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animals>();
            animals.Add(new Fish { Age = 5 });
            animals.Add(new Duck { Age = 9 });
            animals.Add(new Duck { Age = 3 });
            animals.Add(new Dog { Age = 5 });


            foreach (var animal in animals)
            {
                var soundMaker = animal as IMakeSound;
                if (soundMaker != null)
                {
                    soundMaker.MakeSound();
                }


                var wateranimal = animal as IAmWaterAnimal;
                if (wateranimal != null)
                {
                    wateranimal.Swim();
                }
                Console.WriteLine();


            }

        }
    }
}
