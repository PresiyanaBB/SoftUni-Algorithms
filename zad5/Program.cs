using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            string cvqt = Console.ReadLine();
            int red = 0;
            int orange = 0;
            int green = 0;
            int blue = 0;

            do
            {
                if (cvqt == "red") red++;
                else if (cvqt == "orange") orange++;
                else if (cvqt == "green") green++;
                else if (cvqt == "blue") blue++;
                broi--;
                cvqt = Console.ReadLine();
            }
            while (broi>0);

            Console.WriteLine("Red eggs: {0}\nOrange eggs: {1}\nBlue eggs: {2}\nGreen eggs: {3}", red, orange, blue, green);
            if(Math.Max(Math.Max(red, orange), Math.Max(blue, green)) == red)
            {
                Console.WriteLine("Max eggs: {0} -> red", red);
            }
            else if (Math.Max(Math.Max(red, orange), Math.Max(blue, green)) == orange)
            {
                Console.WriteLine("Max eggs: {0} -> orange", orange);
            }
            else if (Math.Max(Math.Max(red, orange), Math.Max(blue, green)) == blue)
            {
                Console.WriteLine("Max eggs: {0} -> blue", blue);
            }
            else Console.WriteLine("Max eggs: {0} -> green", green);
        }
    }
}
