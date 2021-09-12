using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverComand
    {
        public enum MovementCommand
        {
            left,
            right,
            m
        }
        public enum Direction
        {
            South,
            East,
            North,
            West 
        }
        public Direction turnLeft(Direction curentDirection)
        {
            var newDirection = Direction.South;
            switch (curentDirection)
            {
                case Direction.South:
                    newDirection = Direction.East; 
                    break;
                case Direction.East:
                    newDirection = Direction.South;
                    break;
                case Direction.North:
                    newDirection = Direction.East;
                    break;
                case Direction.West:
                    newDirection = Direction.North;
                    break;
            }
            return newDirection;
        }
        public Direction turnRigh(Direction curentDirection)
        {
            var newDirection = Direction.South;
            switch (curentDirection)
            {
                case Direction.South:
                    newDirection = Direction.West;
                    break;
                case Direction.East:
                    newDirection = Direction.South;
                    break;
                case Direction.North:
                    newDirection = Direction.East;
                    break;
                case Direction.West:
                    newDirection = Direction.North;
                    break;
            }
            return newDirection;
        }
        public void move()
        {

        }
    }
}
