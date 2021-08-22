using MarsRoverProblemSolution.Data;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class RotateSameDirection : Provider.Command
    {
        /// maximum limit of rover
        /// </summary>
        private List<int> maxLst = new List<int>();


        public RotateSameDirection(List<int> maxLst)
        {
            this.maxLst = maxLst;
        }

        public Position Execute(Position coordinates)
        {
            var direction = coordinates.Direction.ToString();
            switch (direction)
            {
                case nameof(Directions.N):
                    coordinates.Y += 1;
                    break;
                case nameof(Directions.S):
                    coordinates.Y -= 1;
                    break;
                case nameof(Directions.E):
                    coordinates.X += 1;
                    break;
                case nameof(Directions.W):
                    coordinates.X -= 1;
                    break;
                default:
                    break;
            }

            return coordinates;
        }
    }
}
