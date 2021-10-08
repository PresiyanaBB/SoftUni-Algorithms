using System;

namespace recursion7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse( Console.ReadLine());
            Console.WriteLine(Getf(n));
        }

        private static int Getf(int n)
        {
            if(n<=1)
            {
                return 1;
            }
            return Getf(n - 1) + Getf(n - 2); 
        }
    }
}
