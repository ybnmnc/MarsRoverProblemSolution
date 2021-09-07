using MarsRoverProblemSolution.Data;
using MarsRoverProblemSolution.Repository.Command;
using MarsRoverProblemSolution.Repository.Provider;
using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Business
{
    public class MarsRoverService : IMarsRoverService
    {
        public List<Rover> MoveRover(Plateau plateau, Rover[] rovers, Invoker invoker)
        {
            Command command;
            List<Rover> roverResult = new List<Rover>();

            foreach (var rover in rovers)
            {
                foreach (var item in rover.MovePattern)
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
                            command = new RotateSameDirection();
                            break;
                        default:
                            return null;
                    }

                    var response = invoker.StartMoving(command, rover, plateau);

                    if (response.Rover_X < plateau.X && response.Rover_Y < plateau.Y)
                    {

                        rover.Direction = response.Direction;
                        rover.Rover_X = response.Rover_X;
                        rover.Rover_Y = response.Rover_Y;
                    }
                    else if (response.Flag == false)
                    {
                        //Console.WriteLine("Rıp KOORDINATI...");
                        response.Direction = Directions.RIP;

                    }
                    else
                    {
                        rover.Direction = response.Direction;
                        Console.WriteLine("plato kordınatları asıldı..");
                    }
                }

                roverResult.Add(rover);
            }
            return roverResult;
        }
    }
}
