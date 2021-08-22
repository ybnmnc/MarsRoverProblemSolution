using MarsRoverProblemSolution.Business;
using MarsRoverProblemSolution.Repository.Invoker;
using MarsRoverProblemSolution.Repository.Provider;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRoverProblemSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            var maxPoints = Console.ReadLine().Split(' ');
            var currentLocation = Console.ReadLine().Split(' ');
            var movement = Console.ReadLine();

            var services = new ServiceCollection();

            services.AddSingleton<IMarsRoverService, MarsRoverService>();
            services.AddSingleton<Invoker, ExecuteAction>();
            var _serviceProvider = services.BuildServiceProvider(true);
            var _marsRoverProblemSolutionService = _serviceProvider.GetService<IMarsRoverService>();
            var _invoker = _serviceProvider.GetService<Invoker>();

            var coordinates = _marsRoverProblemSolutionService.MoveRover(maxPoints, currentLocation, movement, _invoker);
            if (coordinates != null)
                Console.WriteLine(coordinates.X + " " + coordinates.Y + " " + coordinates.Direction);

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
