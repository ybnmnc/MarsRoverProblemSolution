using MarsRoverProblemSolution.Data;

namespace MarsRoverProblemSolution.Repository.Invoker
{
    public class ExecuteAction : Provider.Invoker
    {
        // <summary>
        /// start movement of rover
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public Rover StartMoving(Provider.Command command, Rover coordinates,Plateau plateau)
        {
            return command.Execute(coordinates,plateau);
        }
    }
}
