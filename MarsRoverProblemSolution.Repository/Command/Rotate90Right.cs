﻿using MarsRoverProblemSolution.Data;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class Rotate90Right : Provider.Command
    {
        public Position Execute(Position coordinates)
        {
            var direction = coordinates.Direction.ToString();

            switch (direction)
            {
                case nameof(Directions.N):
                    coordinates.Direction = Directions.E;
                    break;
                case nameof(Directions.S):
                    coordinates.Direction = Directions.W;
                    break;
                case nameof(Directions.E):
                    coordinates.Direction = Directions.S;
                    break;
                case nameof(Directions.W):
                    coordinates.Direction = Directions.N;
                    break;
                default:
                    break;
            }
            return coordinates;
        }
    }
}