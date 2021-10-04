using System;

namespace recursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            var list = new int[n];
            Get01(list, 0);
        }

        private static void Get01(int[] list, int v)
        {
            if( v == list.Length )
            {
                Console.WriteLine(string.Join("",list));
                return;
            }
            for(int i=0;i<=1;i++)
            {
                list[v] = i;
                Get01(list, v + 1);
            }
        }
    }
}
