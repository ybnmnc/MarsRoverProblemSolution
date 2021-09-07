using MarsRoverProblemSolution.Data;

namespace MarsRoverProblemSolution.Repository.Provider
{
    public interface Invoker
    {
        /// <summary>
        /// start rover movement
        /// </summary>
        /// <param name="command"></param>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        Rover StartMoving(Command command, Rover coordinates,Plateau plateau);
    }
}

