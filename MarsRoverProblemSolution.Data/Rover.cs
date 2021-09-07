using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Data
{
    public class Rover
    {
        public int Rover_X { get; set; }
        public int Rover_Y { get; set; }

        public Directions Direction { get; set; }
        public Plateau PlateauObj { get; set; }
        public String MovePattern { get; set; }

        public bool Flag { get; } = false;

        public Rover(int x, int y, Directions directions, string movePattern, Plateau plateau)
        {
            if (x > 0 && y > 0 && x <= plateau.X && y <= plateau.Y)
            {
                Rover_X = x;
                Rover_Y = y;
                Direction = directions;
                MovePattern = movePattern;
                PlateauObj = plateau;
            }
            else
            {
                throw new Exception("kordınatlar plato alanına uygun degıl.");
            }
        }

    }
}
