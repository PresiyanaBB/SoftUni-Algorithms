using System;

namespace zad4
{
    class Program
    {
        public static string battle;
        static void Main(string[] args)
        {
            int purvi = int.Parse(Console.ReadLine());
            int vtori = int.Parse(Console.ReadLine());
            battle = Console.ReadLine();
            do
            {
                if (battle=="one") 
                { 
                    vtori--;
                }
                else if(battle=="two")
                {
                    purvi--;
                }
                battle = Console.ReadLine();
            }
            while (battle != "End of battle" && purvi!=0 && vtori!=0);

            if (vtori == 0)
            {
                Console.WriteLine("Player two is out of eggs. Player one has {0} eggs left.", purvi);
            }
            else if (purvi == 0)
            {
                Console.WriteLine("Player one is out of eggs. Player two has {0} eggs left.", vtori);
            }
            else
            {
                Console.WriteLine("Player one has {1} eggs left.\nPlayer two has {0} eggs left.", vtori,purvi);
            }

        }
    }
}
