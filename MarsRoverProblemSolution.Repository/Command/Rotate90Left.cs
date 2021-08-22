using MarsRoverProblemSolution.Data;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class Rotate90Left : Provider.Command
    {
        public Position Execute(Position coordinates)
        {
            var direction = coordinates.Direction.Key;

            switch (direction)
            {
                case nameof(Directions.N):
                    coordinates.Direction = Directions.W;
                    break;
                case nameof(Directions.S):
                    coordinates.Direction = Directions.E;
                    break;
                case nameof(Directions.E):
                    coordinates.Direction = Directions.N;
                    break;
                case nameof(Directions.W):
                    coordinates.Direction = Directions.S;
                    break;
                default:
                    break;
            }

            return coordinates;
        }
    }
}
