using System;

namespace LatihanLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            byte angka_awal, angka_akhir, angka;

            Console.Write("Masukkan angka awal: ");
            angka_awal = Convert.ToByte(Console.ReadLine());

            Console.Write("Masukkan angka akhir: ");
            angka_akhir = Convert.ToByte(Console.ReadLine());

            for(angka = angka_awal; angka <= angka_akhir; angka++)
            {
                if(angka % 2 != 0)
                {
                    Console.WriteLine("Angka {0} adalah bilangan ganjil", angka);
                }
                else
                {
                    Console.WriteLine("Angka {0} adalah bilangan genap", angka);
                }
            }
        }
    }
}
