using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover //Rover class to contain the X and Y location plus the direction it is facing
    {
        int X = 0; // x location of rover 
        int Y = 0; // y location of rover 
        private RoverComand.Direction direction = RoverComand.Direction.South; // direction the rover is facing

        public int Xset
        {
            get { return X; }
            set { X = value; }
        }

        public int Yset
        {
            get { return Y; }
            set { Y = value; }
        }
        public RoverComand.Direction Directionset
        {
            get { return direction; }
            set { direction = value; }
        }
    }
}
