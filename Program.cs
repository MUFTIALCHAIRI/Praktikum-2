﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace kalkulator_konsol_app
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Title = "KALKULATOR";
            Console.WriteLine(" Pilih Menu ");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. keluar");

            Console.WriteLine("input menu:");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    penambahan();
                    Console.ReadKey();
                    break;
                case 2:
                    pengurangan();
                    Console.ReadKey();
                    break;
                case 3:
                    perkalian();
                    Console.ReadKey();
                    break;
                case 4:
                    pembagian();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Terima kasih telah menggunakan kalkulator ini.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Input yang Anda masukkan tidak valid. Silahkan coba lagi.");
                    break;
            }


        }
        static void penambahan()
        {
            Console.WriteLine("Nilai A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nilai B: ");
            int b = int.Parse(Console.ReadLine());
            int hasil = a + b;
            Console.WriteLine("Hasil Dari " + a + " + " + b + " = " + hasil);

        }
        static void pengurangan()
        {
            Console.WriteLine("Nilai A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nilai B: ");
            int b = int.Parse(Console.ReadLine());
            int hasil = a - b;
            Console.WriteLine("Hasil Dari " + a + " - " + b + " = " + hasil);
        }
        static void perkalian()
        {
            Console.WriteLine("Nilai A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nilai B: ");
            int b = int.Parse(Console.ReadLine());
            int hasil = a * b;
            Console.WriteLine("Hasil Dari " + a + " x " + b + " = " + hasil);
        }
        static void pembagian()
        {
            Console.WriteLine("Nilai A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nilai B: ");
            int b = int.Parse(Console.ReadLine());
            int hasil = a / b;
            Console.WriteLine("Hasil Dari " + a + " / " + b + " = " + hasil);
        }
       
    }





}