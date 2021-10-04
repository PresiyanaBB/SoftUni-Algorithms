using System;

namespace recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Formichka(n);
        }

        private static void Formichka(int n)
        {
            if(n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*',n));
            Formichka(n - 1);
            Console.WriteLine(new string('-', n));

        }
    }
}
