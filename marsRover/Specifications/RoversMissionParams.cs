using System;
using System.Collections.Generic;
using System.Drawing;
using marsRover.Dtos;
using marsRover.Entities;

namespace marsRover.Specifications
{
    public class RoversMissionParams
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<RoverDto> RoversWithTheirInstructions { get; set; }
    }
}