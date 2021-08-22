using MarsRoverProblemSolution.Business;
using MarsRoverProblemSolution.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRoverProblemSolution.Tests
{
    public class Rotate90LeftTest :TestBase
    {
        public Rotate90LeftTest()
        {

        }

        public override IServiceProvider Initialize(Action<IServiceCollection> action = null)
        {
            var response = new Position()
            {
                X = 1,
                Y = 1,
                Direction = Directions.N
            };

            //var mockMarsRoverService = new Mock<IMarsRoverService>();


            var serviceProvider = base.Initialize(services =>
            {

                //services.AddSingleton(mockMarsRoverService);
                action?.Invoke(services);

            });

            return serviceProvider;

        }

    }
}
