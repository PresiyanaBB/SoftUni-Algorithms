using System;
using System.Collections.Generic;

namespace recursion6
{
    class Program
    {
        public static HashSet<int> attRow = new HashSet<int>();
        public static HashSet<int> attCol = new HashSet<int>();
        public static HashSet<int> attLeftDial = new HashSet<int>();
        public static HashSet<int> attRightDial = new HashSet<int>();

        static void Main(string[] args)
        {
            var board = new bool[8, 8];
            PutQueens(board, 0);
        }

        private static void PutQueens(bool[,] board, int row)
        {
            if(row == board.GetLength(0))
            {
                PrintQueens(board);
                return;
            }
            for(int col=0;col<board.GetLength(1);col++)
            {
                if(!isAtt(row,col))
                {
                    board[row, col] = true;
                    attRow.Add(row);
                    attCol.Add(col);
                    attLeftDial.Add(row - col);
                    attRightDial.Add(row + col);

                    PutQueens(board, row + 1);

                    board[row, col] = false;
                    attRow.Remove(row);
                    attCol.Remove(col);
                    attLeftDial.Remove(row - col);
                    attRightDial.Remove(row + col);
                }
            }
        }
        private static bool isAtt(int row,int col)
        {
            return attRow.Contains(row) ||
                    attCol.Contains(col) ||
                    attLeftDial.Contains(row - col) ||
                    attRightDial.Contains(row + col);
        }
        private static void PrintQueens(bool[,] board)
        {
            for(int r =0; r<board.GetLength(0);r++)
            {
                for(int c=0; c<board.GetLength(1);c++)
                {
                    if(board[r,c]==true)
                    {
                        Console.Write("* ");

                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
