using System;

namespace PassByValue
{
    class Program
    {

        public static void tambahNilai(int nilai)
        {
            nilai += 5;
            Console.WriteLine("Nilai di dalam method: " + nilai);
        }

        static void Main(string[] args)
        {

            int angka = 10;
            Console.WriteLine("Sebelum menggunakan method: " + angka);
            tambahNilai(angka);
            Console.WriteLine("Setelah menggunakan method: " + angka);

        }
    }
}
