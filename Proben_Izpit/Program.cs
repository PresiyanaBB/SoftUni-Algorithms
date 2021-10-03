using System;

namespace Proben_Izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            double kozunak = 3.20;
            double qica = 4.35;
            double kurabii = 5.40;
            double boq = 0.15;

            int purvo = int.Parse(Console.ReadLine());
            int vtoro = int.Parse(Console.ReadLine());
            int treto = int.Parse(Console.ReadLine());

            Console.WriteLine((purvo * kozunak + vtoro * qica + treto * kurabii + vtoro * boq * 12).ToString("F2"));
        }
    }
}
