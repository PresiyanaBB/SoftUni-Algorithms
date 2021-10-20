using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string durjava = Console.ReadLine();
            string data = Console.ReadLine();
            int noshtuvki = int.Parse(Console.ReadLine());

            if(durjava == "Germany")
            {
                if (data == "21-23") Console.WriteLine("Easter trip to Germany : {0} leva.", (noshtuvki * 32).ToString("F2"));
                else if (data == "24-27") Console.WriteLine("Easter trip to Germany : {0} leva.", (noshtuvki * 37).ToString("F2"));
                else Console.WriteLine("Easter trip to Germany : {0} leva.", (43 * noshtuvki).ToString("F2"));
            }
            else if (durjava == "Italy")
            {
                if (data == "21-23") Console.WriteLine("Easter trip to Italy : {0} leva.", (noshtuvki * 28).ToString("F2"));
                else if (data == "24-27") Console.WriteLine("Easter trip to Italy : {0} leva.", (noshtuvki * 32).ToString("F2"));
                else Console.WriteLine("Easter trip to Italy : {0} leva.", (39 * noshtuvki).ToString("F2"));
            }
            else
            {
                if (data == "21-23") Console.WriteLine("Easter trip to France : {0} leva.", (noshtuvki * 30).ToString("F2"));
                else if (data == "24-27") Console.WriteLine("Easter trip to France : {0} leva.", (noshtuvki * 35).ToString("F2"));
                else Console.WriteLine("Easter trip to France : {0} leva.", (40 * noshtuvki).ToString("F2"));
            }

        }
    }
}
