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

            //var mockCustomerService = new Mock<MarsRoverService.IMarsRoverService>();


            var serviceProvider = base.Initialize(services =>
            {

                //services.AddSingleton(new InventoryServiceAdapter(null, null));
                action?.Invoke(services);

            });

            return serviceProvider;

        }

    }
}
