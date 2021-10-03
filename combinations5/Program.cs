using System;

namespace combinations5
{
    class Program
    {
        public static string[] elements;
        public static int k;
        public static string[] combinations;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            //Console.WriteLine();

            Combos(0, 0);
        }

        private static void Combos(int nomer, int startov)
        {
            if (nomer >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = startov; i < elements.Length; i++)
            {
                combinations[nomer] = elements[i];
                Combos(nomer + 1, i );
            }
        }
    }
}
