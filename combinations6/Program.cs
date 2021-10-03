using System;

namespace combinations6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            Console.WriteLine(Paskal(n, k));
        }

        private static int Paskal(int row, int col)
        {
            if(row==0 || row==1 || col==0 || col==row)
            {
                return 1;
            }

            return Paskal(row - 1, col - 1) + Paskal(row - 1, col);
        }
    }
}
