using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningInterfaces
{
    class Dog : Animals, IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine($"Waf Waf, ik ben {Age} jaar");
        }
    }
}
