using System;

namespace zad2
{
    class Program
    {

        static void Main(string[] args)
        {
            double purvo = double.Parse(Console.ReadLine());
            double vtoro = double.Parse(Console.ReadLine());
            double treto = double.Parse(Console.ReadLine());

            double helper;

            if (purvo < 10)
            {
                helper = purvo * vtoro + 0.1 * treto;
                GetAll(helper, treto);
            }
            else if (purvo < 16)
            {
                helper = purvo * vtoro * 0.85 + 0.1 * treto;
                GetAll(helper, treto);
            }
            else if (purvo < 21)
            {
                helper = purvo * vtoro * 0.80 + 0.1 * treto;
                GetAll(helper, treto);
            }
            else
            {
                helper = purvo * vtoro * 0.75 + 0.1 * treto;
                GetAll(helper, treto);
            }
        }

        private static void GetAll(double helper, double treto)
        {
            if (helper < treto)
            {
                Console.WriteLine("It is party time! {0} leva left.", (treto - helper).ToString("F2"));
            }
            else
            {
                Console.WriteLine("No party! {0} leva needed.", (helper - treto).ToString("F2"));
            }
        }
    }
}
