using System.Collections.Generic;
using marsRover.Dtos;
using marsRover.Entities;

namespace marsRover.Interfaces
{
    public interface IRoverService
    {
        public List<Rover> ExecuteTheMission(List<RoverDto> RoversWithTheirInstructions);
    }
}