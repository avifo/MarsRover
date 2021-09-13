using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverComand
    {
        //enum containing all the directions
        public enum Direction 
        {
            South,
            East,
            North,
            West
        }

        //method to change the direction to left of the rover
        public Direction turnLeft(Rover rover) 
        {
            switch (rover.Directionset) //switch statement takes in the currenct facing direction of the rover and changes it based on it
            {
                case Direction.South:
                    rover.Directionset = Direction.East;
                    break;
                case Direction.East:
                    rover.Directionset = Direction.South;
                    break;
                case Direction.North:
                    rover.Directionset = Direction.East;
                    break;
                case Direction.West:
                    rover.Directionset = Direction.North;
                    break;
            }
            return rover.Directionset;
        }

        //method to change the direction to right of the rover
        public Direction turnRigh(Rover rover)
        {
            switch (rover.Directionset)//switch statement takes in the currenct facing direction of the rover and changes it based on it
            {
                case Direction.South:
                    rover.Directionset = Direction.West;
                    break;
                case Direction.East:
                    rover.Directionset = Direction.South;
                    break;
                case Direction.North:
                    rover.Directionset = Direction.East;
                    break;
                case Direction.West:
                    rover.Directionset = Direction.North;
                    break;
            }
            return rover.Directionset;
        }

        //method that moves the rover based on how many tiles are needed to be moved
        public Rover move(string distance, Rover rover, int location, int[,] roverArea)
        {
            int dis = Int32.Parse(distance); //change the string to int
            int backupX = rover.Xset; //backup of the x and y location so that if the user goes beyond the designated area they can go back to the location they were in
            int backupY = rover.Yset;
            try 
            {
                switch (rover.Directionset) //switch statement to know which axis needs to change based on direction facing
                {
                    case Direction.North:
                        rover.Yset = rover.Yset - dis;
                        break;
                    case Direction.South:
                        rover.Yset = rover.Yset + dis;
                        break;
                    case Direction.East:
                        rover.Xset = rover.Xset + dis;
                        break;
                    case Direction.West:
                        rover.Xset = rover.Xset - dis;
                        break;
                }
                location = roverArea[rover.Xset, rover.Yset];
            }
            catch (Exception) //catch to make sure that the user can go back to the previus state beforer they went out of bound
            {
                Console.WriteLine("You went out of the designated area");
                rover.Xset = backupX;
                rover.Yset = backupY;

            }
            return rover;
        }
    }
}


