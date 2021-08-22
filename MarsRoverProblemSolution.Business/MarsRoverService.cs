using MarsRoverProblemSolution.Data;
using MarsRoverProblemSolution.Repository.Command;
using MarsRoverProblemSolution.Repository.Provider;
using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Business
{
    public class MarsRoverService : IMarsRoverService
    {
        public Position MoveRover(string[] maxPoints, string[] currentLocation, string movement, Invoker invoker)
        {
            var maxList = new List<int>();
            var positions = new Position();
            Command command;

            foreach (var item in maxPoints)
            {
                var point = Convert.ToInt32(item);
                maxList.Add(point);
            }

            positions.X = Convert.ToInt32(currentLocation[0]);
            positions.Y = Convert.ToInt32(currentLocation[1]);
            positions.Direction = EnumBase.FromKey<Directions>(currentLocation[2]);


            foreach (var item in movement)
            {
                switch (item)
                {
                    case 'L':
                        command = new Rotate90Left();
                        break;
                    case 'R':
                        command = new Rotate90Right();
                        break;
                    case 'M':
                        command = new RotateSameDirection(maxList);
                        break;
                    default:
                        return null;
                }

                var response = invoker.StartMoving(command, positions);

                if (response == null)
                {
                    return null;
                }

                positions.Direction = response.Direction;
                positions.X = response.X;
                positions.Y = response.Y;

            }

            return positions;
        }
    }
}
