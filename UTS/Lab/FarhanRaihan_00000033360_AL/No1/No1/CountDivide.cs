using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1
{
    class CountDivide
    {

        public double pembagian { get; set; }
        public double hitung { get; set; }
        public double index { get; set; }
        public void substract()
        {
            if (index == 0)
            {
                hitung = pembagian;
            }
            else
            {
                hitung = hitung / pembagian;
            }

        }

        public string balikNilai()
        {
            return Convert.ToString(hitung);
        }
    }
}
