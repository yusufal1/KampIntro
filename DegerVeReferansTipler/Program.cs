﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? = 30

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 20, 30 };

        }
    }
}
