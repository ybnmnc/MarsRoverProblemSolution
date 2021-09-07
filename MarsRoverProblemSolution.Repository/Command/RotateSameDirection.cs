using MarsRoverProblemSolution.Data;
using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class RotateSameDirection : Provider.Command
    {
        public Rover Execute(Rover coordinates, Plateau plateau)
        {
            var direction = coordinates.Direction.Key;
            switch (direction)
            {
                case nameof(Directions.N):

                    if (coordinates.Rover_Y <= plateau.Y || coordinates.Rover_Y != 0)
                        coordinates.Rover_Y += 1;
                    else
                        Console.WriteLine("out of bounds");
                    break;


                case nameof(Directions.S):

                    if (coordinates.Rover_Y <= plateau.Y || coordinates.Rover_Y != 0)
                        coordinates.Rover_Y -= 1;
                    else
                        Console.WriteLine("out of bounds");
                    break;


                case nameof(Directions.E):

                    if (coordinates.Rover_X <= plateau.X || coordinates.Rover_X != 0)
                        coordinates.Rover_X += 1;
                    else { Console.WriteLine("out of bounds"); }
                    break;

                case nameof(Directions.W):

                    if (coordinates.Rover_X <= plateau.X || coordinates.Rover_X != 0)
                        coordinates.Rover_X -= 1;
                    else
                        Console.WriteLine("out of bounds");
                    break;
                default:
                    break;
            }

            return coordinates;
        }
    }
}
