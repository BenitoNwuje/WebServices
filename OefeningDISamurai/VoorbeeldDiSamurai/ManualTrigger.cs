using System;
using System.Collections.Generic;
using System.Text;

namespace VoorbeeldDiSamurai
{
    class ManualTrigger : ITrigger
    {
        public void Pull()
        {
            Console.WriteLine("Manual gun");
        }
    }
}
