using System;

namespace combinations3
{
    class Program
    {
        public static string[] elements;
        public static int k;
        public static string[] variations;
        public static bool[] used;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            variations = new string[k];
            used = new bool[elements.Length];

            //Console.WriteLine();

            Varit(0);
        }

        private static void Varit(int index)
        {
            if(index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i<elements.Length;i++)
            {
                if(!used[i])
                {
                    used[i] = true;
                    variations[index] = elements[i];
                    Varit(index + 1);
                    used[i] = false;
                }
                


            }
        }
    }
}
