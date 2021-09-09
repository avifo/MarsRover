using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] roverArea = new char[100, 100]; // array for the gird that the rover is moving around 
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    roverArea[i, j] = '0';
                }
            }
            ShowGrid(roverArea);
            Console.WriteLine("Input 5 commands for the rover");
            Console.ReadLine();
        }

        static void RoverCommands()
        {
            string command1 = "";
            string command2 = "";
            string command3 = "";
            string command4 = "";
            string command5 = "";
        }
        static void ShowGrid(char[,] grid) // displays the grid 
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write("[{0}]", grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
