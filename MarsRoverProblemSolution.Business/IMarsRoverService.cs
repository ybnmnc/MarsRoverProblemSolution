using MarsRoverProblemSolution.Data;
using MarsRoverProblemSolution.Repository.Provider;
using System;
using System.Collections.Generic;

namespace MarsRoverProblemSolution.Business
{
    public interface IMarsRoverService
    {
        //rover movement metod 
        List<Rover> MoveRover(Plateau plateau, Rover[] list, Invoker _invoker);
    }
}
