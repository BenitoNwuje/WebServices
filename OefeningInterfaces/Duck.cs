using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningInterfaces
{
    class Duck : Animals, IAmWaterAnimal, IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine($"Kwak kwak, ik ben {Age} jaar");
        }

        public void Swim()
        {
            Console.WriteLine("De eend zwemt!");
        }
    }
}
