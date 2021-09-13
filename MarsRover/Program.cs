using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            RoverComand roverComand = new RoverComand();
            Rover rover = new Rover();
            string[] inputData = new string[5];
            int[,] roverArea = new int[100, 100]; // array for the gird that the rover is moving around 
            int num = 1;
            int location;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    roverArea[i, j] = num;
                    num++;
                }
            }

            while (true)
            {
                
                location = roverArea[rover.Yset, rover.Xset];
                Console.WriteLine("Current Rover Position: " + location + " " + rover.Directionset);
                Console.WriteLine("Please enter your 5 rover commands");
                string roverCommands = Console.ReadLine().ToLower();
                inputData = roverCommands.Split(' ');
                string meters = "m";
                for (int i = 0; i < inputData.Length; i++)
                {
                    switch (inputData[i])
                    {
                        case "left":

                            rover.Directionset = roverComand.turnLeft(rover);
                            Console.WriteLine("command:left");
                            break;
                        case "right":
                            rover.Directionset = roverComand.turnRigh(rover);
                            Console.WriteLine("command:right");
                            break;
                    }
                    if (inputData[i].Contains(meters))
                    {
                        Console.WriteLine("rover moved: ", inputData[i], "meters");
                        rover = roverComand.move(inputData[i].Trim('m'), rover, location, roverArea);
                    }
                }
            }
        }
    }
}
