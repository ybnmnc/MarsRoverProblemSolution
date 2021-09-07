using MarsRoverProblemSolution.Business;
using MarsRoverProblemSolution.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;
using MarsRoverProblemSolution.Repository.Command;
using MarsRoverProblemSolution.Repository.Provider;

namespace MarsRoverProblemSolution.Tests
{
    public class Rotate90LeftTest : TestBase
    {
        private readonly Command _command;
        public Rotate90LeftTest()
        {
            _command = new Rotate90Left();
        }


        public override IServiceProvider Initialize(Action<IServiceCollection> action = null)
        {

            var serviceProvider = base.Initialize(services =>
            {
                action?.Invoke(services);

            });

            return serviceProvider;

        }

        //[Fact]
        //public void Rotate90LeftTest_Metod_Response_Position_Test()
        //{
        //    var request = new Rover()
        //    {
        //        Rover_X = 1,
        //        Rover_Y = 1,
        //        Direction = Directions.N
        //    };


        //    var response = new Rover()
        //    {
        //        Rover_X = 1,
        //        Rover_Y = 1,
        //        Direction = Directions.W

        //    };

        //    var result = _command.Execute(request);

        //    Assert.NotNull(result);

        //    Assert.Equal(response.Direction, result.Direction);

        //}

    }
}
