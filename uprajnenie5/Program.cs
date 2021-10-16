using System;
using System.Collections.Generic;

namespace uprajnenie5
{
    class Program
    {
        public static int arean = 0;
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var lab = new char[rows, cols];
            for(int r=0; r<rows;r++)
            {
                var line = Console.ReadLine();
                for(int c=0;c<line.Length;c++)
                {
                    lab[r, c] = line[c];
                }
            }

            FindAllSums(lab, 0, 0, arean);
        }

        private static void FindAllSums(char[,] lab, int row, int col, int count)
        {
            if (IsOutside(lab, row, col) || IsWall(lab,row,col)|| IsVisited(lab,row,col))
            {
                return;
            }

            if (IsSolution(lab, row, col))
            {
                arean += 1;
                Console.WriteLine(string.Join("Area ",arean,"at ","(",row,",",col,")"," size ",count));
                count -= 1;
                return;
            }

            lab[row, col] = 'v';

            FindAllSums(lab, row, col + 1, count + 1);
            FindAllSums(lab, row + 1, col, count + 1);
            FindAllSums(lab, row - 1, col, count + 1);
            FindAllSums(lab, row, col - 1, count + 1);

            count -= 1;
            lab[row, col] = '-';
        }

        private static bool IsSolution(char[,] lab, int row, int col)
        {
             return IsOutside(lab, row, col) && IsWall(lab, row, col) && IsVisited(lab, row, col);
        }

        private static bool IsVisited(char[,] lab, int row, int col)
        {
            return lab[row, col] == 'v';
        }

        private static bool IsWall(char[,] lab, int row, int col)
        {
            return lab[row, col] == '*';
        }

        private static bool IsOutside(char[,] lab, int row, int col)
        {
            return row<0 || row>=lab.GetLength(0) || col<0 || col>=lab.GetLength(1);
        }
    }
}
