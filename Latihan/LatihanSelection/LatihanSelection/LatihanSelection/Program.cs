using System;

namespace LatihanSelection
{
    class Program
    {
        static void Main(string[] args)
        {

            int angka = 0 ;

            angka = Console.Read();

            // string angka1;
            // angka1 = Console.ReadLine();

            // angka = Convert.ToInt32(angka1);



            if(angka % 2 == 0)
            {
                Console.Write("Bilangan Genap");
            }
            else
            {
                Console.WriteLine("Bukan Bilangan Genap");
            }

            Console.WriteLine(angka);
        }
    }
}
