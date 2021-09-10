using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Task to do and components:
/// Rover: Location in the Grid(x, y), Direction it is facing (north, west, south, east) 
/// Exploration Area: 100 by 100 grid numbered from 1 to 10000, must be able to contain which direction the rover is pointed at (north, west, south, east) 
/// Controls: User sends 5 commands telling the rover to either turn Left, Right or move a specific amount of meters in the diraction they are facing, 
///           e.g. 50m south is will move the rover down to grid 5000
/// 
/// </summary>

namespace MarsRover
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] inputData = new string[5];
            Console.WriteLine("Please enter your 5 rover commands");
            string roverCommands = Console.ReadLine();
            inputData = roverCommands.Split(' ');

            char[,] roverArea = new char[ExploarionArea.row, ExploarionArea.row]; // array for the gird that the rover is moving around 
            for (int i = 0; i < ExploarionArea.row; i++)
            {
                for (int j = 0; j < ExploarionArea.column; j++)
                {
                    roverArea[i, j] = '0';
                }
            }
            ExploarionArea.ShowGrid(roverArea);
            Console.ReadLine();
        }
    }
}
