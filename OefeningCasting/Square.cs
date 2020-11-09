using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OefeningCasting
{
    class Square
    {
        private int size;

        public int Perimeter { 
            get
            {
                return 4 * size;
            }
        }
        public Square(int size)
        {
            this.size = size;
        }
    }
}
