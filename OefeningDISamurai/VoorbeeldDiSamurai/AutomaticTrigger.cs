using System;
using System.Collections.Generic;
using System.Text;

namespace VoorbeeldDiSamurai
{
    class AutomaticTrigger : ITrigger
    {
        public void Pull()
        {
            Console.WriteLine("Automatic gun");
        }
    }
}
