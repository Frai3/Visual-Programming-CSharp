using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Nilai
    {

        public double tugas { get; set; }
        public double uts { get; set; }
        public double uas { get; set; }
        public double final { get; set; }

        public void calculate()
        {
            final = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4);

        }

        public string nilaiHuruf()
        {
            if(final >= 85 && final <= 100)
            {
                return "A";
            }
            else if (final > 100)
            {
                return "Nilai Melebihi Maksimal";
            }
            else if (final >= 80)
            {
                return "A-";
            }
            else if (final >= 75)
            {
                return "B+";
            }
            else if (final >= 70)
            {
                return "B";
            }
            else if (final >= 65)
            {
                return "B-";
            }
            else if (final >= 60)
            {
                return "C+";
            }
            else if (final >= 55)
            {
                return "C";
            }
            else if (final >= 50)
            {
                return "D";
            }
            else if (final >= 45)
            {
                return "E";
            }
            else
            {
                return "F";
            }
            return null;       
        }
    }
}
