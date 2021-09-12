using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public int X;
        public int Y;
        public string Direction;
        public Rover(int currentX, int currentY, RoverComand.Direction facingDirection)
        {
            currentX = 0;
            currentY = 0;
            facingDirection = 0;
        }
    }
}
