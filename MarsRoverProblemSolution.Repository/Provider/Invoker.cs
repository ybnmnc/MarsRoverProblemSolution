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
        Position StartMoving(Command command, Position coordinates);
    }
}

