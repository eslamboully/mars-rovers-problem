using System.Collections.Generic;
using AutoMapper;
using marsRover.Dtos;
using marsRover.Interfaces;
using marsRover.Entities;

namespace marsRover.Services
{
    public class RoverService : IRoverService
    {
        private readonly IMapper _mapper;
        public RoverService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Rover> ExecuteTheMission(List<RoverDto> RoversWithTheirInstructions)
        {
            var rovers = _mapper.Map<List<RoverDto>, List<Rover>>(RoversWithTheirInstructions);
            for (int i = 0; i < RoversWithTheirInstructions.Count; i++)
            {
                rovers[i].Move(RoversWithTheirInstructions[i].Instructions);
            }

            return rovers;
        }
    }
}