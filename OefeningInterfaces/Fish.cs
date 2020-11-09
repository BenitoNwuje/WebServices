using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningInterfaces
{
    class Fish : Animals, IAmWaterAnimal
    {
        public void Swim()
        {
            Console.WriteLine("De vis zwemt!");
        }
    }
}
