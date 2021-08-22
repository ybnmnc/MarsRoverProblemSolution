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
        public Position StartMoving(Provider.Command command, Position coordinates)
        {
            return command.Execute(coordinates);
        }
    }
}
