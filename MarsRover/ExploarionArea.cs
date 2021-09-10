using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class ExploarionArea
    {
        public static int row = 10;
        public static int column = 10;

        public ExploarionArea(int Row, int Column)
        {
            row = Row;
            column = Column;

        }
        
        public static void ShowGrid(char[,] grid) // displays the grid 
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("[{0}]", grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
