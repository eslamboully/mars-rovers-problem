using marsRover.Enums;

namespace marsRover.Dtos
{
    public class RoverDto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CompassDirection Direction { get; set; }
        public string Instructions { get; set; }
    }
}