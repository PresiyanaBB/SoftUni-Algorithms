﻿using System;
using System.Linq;

namespace softuni2
{
    class Program
    {
        public static string [] elements;
        public static string[] permut;
        public static bool[] used;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            permut = new string[elements.Length];
            used = new bool[elements.Length];

            Permute(0);
        }

        private static void Permute(int index)
        {
            if(index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permut));
                return;
            }

           for (int i =0; i<elements.Length;i++)
            {
                if(!used[i])
                {
                    used[i] = true;
                    permut[index] = elements[i];
                    Permute(index + 1);
                    used[i] = false;
                }
                
            }
        }
    }
}
