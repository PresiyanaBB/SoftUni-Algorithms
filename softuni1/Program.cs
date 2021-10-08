using System;
using System.Linq;
namespace softuni1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(GetSum(list,0));
        }

        private static int GetSum(int[] list,int index)
        {
            if(index >= list.Length)
            {
                return 0;
            }
            return list[index] + GetSum(list, index + 1);
        }
    }
}
