using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1
{
    class CountAdd
    {
        public double penambahan { get; set; }
        public double hitung { get; set; }
        public double index { get; set; }

        public void add()
        {
            if (index == 0)
            {
                hitung = penambahan;
            }
            else
            {
                hitung = hitung + penambahan;
            }
        }

        public string balikNilai()
        {
           return Convert.ToString(hitung);
        }
    }
}
