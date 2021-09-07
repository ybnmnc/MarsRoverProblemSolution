using MarsRoverProblemSolution.Data;

namespace MarsRoverProblemSolution.Repository.Provider
{
    public interface Command
    {
        /// <summary>
        /// execute rover rotation/movement
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public Rover Execute(Rover coordinates,Plateau plateau);
    }
}
