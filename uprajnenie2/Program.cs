using System;

namespace uprajnenie2
{
    class Program
    {
        public static string[] combinations;
        public static string[] elements;
        public static int k;
        public static int count;
        static void Main(string[] args)
        {
            count = 0;
            k = int.Parse(Console.ReadLine());
            elements = new string[k];
            for(int i=0 ; i<k;  i++)
            {
                count++;
                elements[i] = count.ToString();
            }
            combinations = new string[count];
            
            //Console.WriteLine();

            Combos(0);
        }

        private static void Combos(int nomer)
        {
            if (nomer >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = 0 ; i < elements.Length ; i++)
            {
                combinations[nomer] = elements[i];
                Combos(nomer + 1 );
            }
        }
    }
}
