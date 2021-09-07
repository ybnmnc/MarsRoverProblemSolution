using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblemSolution.Data
{
    public class Plateau
    {
        public int X { get; set; }

        public int Y { get; set; }


        public Plateau(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                this.X = x;
                this.Y = y;
            }
            else
            {
                throw new Exception("outside the plateau boundaries");
            }
        }

    }
}
