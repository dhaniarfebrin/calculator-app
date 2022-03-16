using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            //int a = 10; //deklarasi variable
            //int b = 99; //deklarasi variable

            Console.WriteLine("Menu Kalkulator Sederhana");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Pilih salah satu operasi [1-4] : ");
            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan >= 1 && pilihan <= 4) {

                Console.Write("Inputkan bilangan a = ");
                int a = int.Parse(Console.ReadLine()); // menangkap nilai lalu diubah ke int

                Console.Write("Inputkan bilangan b = ");
                int b = int.Parse(Console.ReadLine()); // menangkap nilai lalu diubah ke int

                Console.WriteLine(); // memberi baris kosong

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", a, b, Penambahan(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                        break;
                }

            } else {
                Console.WriteLine();
                Console.WriteLine("Maaf, Menu yang anda pilih tidak tersedia");
            }

            // Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penambahan(a, b));
            // Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            // Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            // Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
