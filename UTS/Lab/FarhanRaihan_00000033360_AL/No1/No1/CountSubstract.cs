using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1
{
    class CountSubstract
    {
        public double pengurangan { get; set; }
        public double hitung { get; set; }
        public double index { get; set; }
        public void substract()
        {
            if(index == 0)
            {
                hitung = pengurangan;
            }
            else
            {
                hitung = hitung - pengurangan;
            }
            
        }

        public string balikNilai()
        {
            return Convert.ToString(hitung);
        }

    }
}
