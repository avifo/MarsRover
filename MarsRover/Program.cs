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
        public static void Main(string[] args)
        {
            string[] inputData = new string[5];

            char[,] roverArea = new char[ExploarionArea.row, ExploarionArea.row]; // array for the gird that the rover is moving around 
            for (int i = 0; i < ExploarionArea.row; i++)
            {
                for (int j = 0; j < ExploarionArea.column; j++)
                {
                    roverArea[i, j] = '0';
                }
            }
            ExploarionArea.ShowGrid(roverArea);
            Console.WriteLine("Input 5 commands for the rover");
            for (int i = 0; i < 5; i++)
            {
                inputData[i];
                Console.WriteLine(i);
            }
        }

        static void RoverCommands()
        {
            string command1 = "";
            string command2 = "";
            string command3 = "";
            string command4 = "";
            string command5 = "";
        }
    }
}
