using MarsRoverProblemSolution.Data;
using MarsRoverProblemSolution.Repository.Provider;

namespace MarsRoverProblemSolution.Business
{
    public interface IMarsRoverService
    {
        //rover movement.
        Position MoveRover(string[] maxPoints, string[] currentLocation, string movement, Invoker _invoker);
    }
}
