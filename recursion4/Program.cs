using System;

namespace recursion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetF(n));
        }

        private static int GetF(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return  n * GetF(n-1);
        }
    }
}
