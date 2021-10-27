using System;
using System.Collections.Generic;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> tochki = new List<int>();
            int kolko = int.Parse(Console.ReadLine());
            string ime;
            string zapis;
            int ocenka = 0;
            for(int i=0;i<kolko;i++)
            {
                ime = Console.ReadLine();
                names.Add(ime);
                zapis = Console.ReadLine();
                do
                {
                    ocenka += int.Parse(zapis);
                    zapis = Console.ReadLine();
                }
                while (zapis != "Stop");
                tochki.Add(ocenka);
                ocenka = 0;
            }
            for(int i=0;i<kolko;i++)
            {
                Console.WriteLine(names[i] + " has {0} points.", tochki[i]);
                if (i == 0) Console.WriteLine(names[0] + " is the new number 1!");
                else if (tochki[i] > tochki[i - 1])
                {
                    Console.WriteLine(names[i] + " is the new number 1!");
                    ocenka = i;
                }
            }
            Console.WriteLine(names[ocenka]+" won competition with {0} points!",tochki[ocenka]);
        }
    }
}
