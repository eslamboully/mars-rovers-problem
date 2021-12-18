using System;
using marsRover.Enums;

namespace marsRover.Entities
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CompassDirection Direction { get; set; }

        public void Move(string instructions)
        {
            foreach(char instruction in instructions)
            {
                switch(instruction) 
                {
                case 'L':
                    Rotate90DegreeLeft();
                    break;
                case 'R':
                    Rotate90DegreeRight();
                    break;
                case 'M':
                    MoveForward();
                    break;
                default:
                    break;
                }
            }
        }
        private void MoveForward()
        {
            switch(this.Direction)
            {
                case CompassDirection.N:
                    this.Y = this.Y+1;
                    break;
                case CompassDirection.S:
                    this.Y = this.Y-1;
                    break;
                case CompassDirection.E:
                    this.X = this.X+1;
                    break;
                case CompassDirection.W:
                    this.X = this.X-1;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90DegreeLeft()
        {
            switch (this.Direction)
            {
                case CompassDirection.N:
                    this.Direction = CompassDirection.W;
                    break;
                case CompassDirection.S:
                    this.Direction = CompassDirection.E;
                    break;
                case CompassDirection.E:
                    this.Direction = CompassDirection.N;
                    break;
                case CompassDirection.W:
                    this.Direction = CompassDirection.S;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90DegreeRight()
        {
            switch (this.Direction)
            {
                case CompassDirection.N:
                    this.Direction = CompassDirection.E;
                    break;
                case CompassDirection.S:
                    this.Direction = CompassDirection.W;
                    break;
                case CompassDirection.E:
                    this.Direction = CompassDirection.S;
                    break;
                case CompassDirection.W:
                    this.Direction = CompassDirection.N;
                    break;
                default:
                    break;
            }
        }
    }
}