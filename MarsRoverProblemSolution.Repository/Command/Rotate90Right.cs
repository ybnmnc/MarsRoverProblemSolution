using MarsRoverProblemSolution.Data;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class Rotate90Right : Provider.Command
    {
        public Rover Execute(Rover coordinates,Plateau plateau)
        {
            bool flag = false;
            var direction = coordinates.Direction.Key;

            switch (direction)
            {
                case nameof(Directions.N):
                    coordinates.Direction = Directions.E;
                    flag = true;
                    break;
                case nameof(Directions.S):
                    coordinates.Direction = Directions.W;
                    flag = true;
                    break;
                case nameof(Directions.E):
                    coordinates.Direction = Directions.S;
                    flag = true;
                    break;
                case nameof(Directions.W):
                    coordinates.Direction = Directions.N;
                    flag = true;
                    break;
                default:
                    break;
            }
            return coordinates;
        }
    }
}
