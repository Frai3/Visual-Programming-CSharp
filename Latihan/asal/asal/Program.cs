using System;

namespace asal
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil MobilSaya = new Mobil(); //{ nama = "Ferrari", kecepatan = 0, bensin = 1000, posisi = 0 };

            MobilSaya.nama = "Ferrari";
            MobilSaya.kecepatan = 0;
            MobilSaya.bensin = 1000;
            MobilSaya.posisi = 0;

            Console.WriteLine("Sebelum");
            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin + " ml");
            Console.WriteLine(MobilSaya.kecepatan + " Km/Jam");
            Console.WriteLine(MobilSaya.posisi + " M");
            Console.WriteLine(" ");

            MobilSaya.percepat();
            Console.WriteLine("Sesudah");
            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin + " ml");
            Console.WriteLine(MobilSaya.kecepatan + " Km/Jam");
            Console.WriteLine(MobilSaya.posisi + " M");
            Console.ReadKey();
        }
    }

    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;

        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
            this.posisi += 20;
        }
        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }
        public void isiBensin(double bensin)
        {
            this.bensin += bensin;
        }
    }
}
