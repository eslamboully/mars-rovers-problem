using AutoMapper;
using marsRover.Dtos;
using marsRover.Entities;

namespace marsRover.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoverDto, Rover>();
        }
    }
}