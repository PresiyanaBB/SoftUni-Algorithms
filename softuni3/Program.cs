using System;
using System.Linq;

namespace softuni3
{
    class Program
    {
        public static string[] list;
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split();
            Reverse(0, list);
            Console.WriteLine(string.Join(" ", list));
        }

        private static void Reverse(int left, string[] list)
        {
            if(left >= list.Length/2)
            {
                return;
            }
            var right = list.Length - 1 - left;
            Swap(list, left, right);
            Reverse(left + 1, list);
        }

        private static void Swap(string[] list, int first, int second)
        {
            var temp = list[first];
            list[first] = list[second];
            list[second] = temp;
        }
    }
}
