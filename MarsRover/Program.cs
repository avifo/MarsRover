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
            RoverComand roverComand = new RoverComand(); //instance of rover comand
            Rover rover = new Rover();// instance of the rover that is being moved
            string[] inputData = new string[5]; // array of user input
            int[,] roverArea = new int[100, 100]; // array for the gird that the rover is moving around 
            int num = 1; //used to populate the grid
            int location; //the location of the rover

            for (int i = 0; i < 100; i++) //for loop to populate the grid
            {
                for (int j = 0; j < 100; j++)
                {
                    roverArea[i, j] = num;
                    num++;
                }
            }

            while (true) //keeps the program going for how long the user needs 
            {
                
                location = roverArea[rover.Yset, rover.Xset]; //takes the rover location and input the x and y used to calculate where the rover is going
                Console.WriteLine("Current Rover Position: " + location + " " + rover.Directionset); 
                Console.WriteLine("Please enter your 5 rover commands");
                string roverCommands = Console.ReadLine().ToLower(); // reads in the users rover comand and make sure it is in lower case
                inputData = roverCommands.Split(' '); // splits the commands and store them in the array
                string meters = "m"; // to check if the user wants to move
                for (int i = 0; i < inputData.Length; i++) // goes through the command array and process all the commands 
                {
                    switch (inputData[i]) // switch statement to check all the rover commands 
                    {
                        case "left": // if the rover wants to turn left this is used

                            rover.Directionset = roverComand.turnLeft(rover); // calls on the turnLeft method in roverComand class 
                            Console.WriteLine("command:left");
                            break;
                        case "right":
                            rover.Directionset = roverComand.turnRigh(rover);// calls on the turnRight method in roverComand class
                            Console.WriteLine("command:right");
                            break;
                    }
                    if (inputData[i].Contains(meters)) // if the string contains "m" go to the move method in roverComand
                    {
                        Console.WriteLine("rover moved: ", inputData[i], "meters");
                        rover = roverComand.move(inputData[i].Trim('m'), rover, location, roverArea); // move the rover based on what the input is usign the rover, location and rover area variables. 
                    }
                }
            }
        }
    }
}
