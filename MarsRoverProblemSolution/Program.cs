using MarsRoverProblemSolution.Business;
using MarsRoverProblemSolution.Data;
using MarsRoverProblemSolution.Repository.Invoker;
using MarsRoverProblemSolution.Repository.Provider;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rover[] roverList = new Rover[2];
            Plateau plateau = new Plateau(5, 5);
            String[] movementList = new string[2];


            Console.WriteLine("First rover movement write plaese!!");
            movementList[0] = Console.ReadLine();
            Console.WriteLine("Second rover movement write please!!");
            movementList[1] = Console.ReadLine();

            roverList[0] = new Rover(1, 2, Directions.N, movementList[0], plateau);
            roverList[1] = new Rover(3, 3, Directions.E, movementList[1], plateau);

            var services = new ServiceCollection();

            services.AddSingleton<IMarsRoverService, MarsRoverService>();
            services.AddSingleton<Invoker, ExecuteAction>();
            var _serviceProvider = services.BuildServiceProvider(true);
            var _marsRoverProblemSolutionService = _serviceProvider.GetService<IMarsRoverService>();
            var _invoker = _serviceProvider.GetService<Invoker>();

            var coordinates = _marsRoverProblemSolutionService.MoveRover(plateau, roverList, _invoker);
            if (coordinates != null)

                Console.WriteLine("Fırst rover movement result:{0} {1} {2}", coordinates[0].Rover_X, coordinates[0].Rover_Y, coordinates[0].Direction.Key);
            Console.WriteLine("Second rover movement result:{0} {1} {2}", coordinates[1].Rover_X, coordinates[1].Rover_Y, coordinates[1].Direction.Key);

            DisposeServices(_serviceProvider);
        }

        private static void DisposeServices(ServiceProvider _serviceProvider)
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
