using System;
using System.Collections.Generic;

namespace combinations2
{
    class Program
    {
        public static string[] elements;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            Console.WriteLine();
            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            Permute(index + 1);
            var swapped = new HashSet<string>();
            swapped.Add(elements[index]);

            for (int i = index + 1; i < elements.Length; i++)
            {
                if (!swapped.Contains(elements[i]))
                {
                    Swap(index,i);
                    Permute(index + 1);
                    Swap(index,i);
                    swapped.Add(elements[i]);
                }

            }
        }

        private static void Swap(int index, int i)
        {
            var sth = elements[index];
            elements[index] = elements[i];
            elements[i] = sth;
        }
    }
}
