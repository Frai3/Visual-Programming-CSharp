using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class perhitungan
    {

        public double hasilKonsumsi, hasilTransportasi, hasilAkomodasi, hasilKomunikasi, hasilKuliah, hasilBuku;

        public double hitungAkomodasi(double akomodasi, int semester)
        {
            return hasilAkomodasi = akomodasi * 6 * semester;
        }

        public double hitungKonsumsi(double konsumsi, int semester)
        {
            return hasilKonsumsi = konsumsi * (30 * 6) * semester;
        }

        public double hitungTransportasi(double transportasi, int semester)
        {
            return hasilTransportasi = transportasi * (52 / 2) * semester;
        }

        public double hitungKomunikasi(double komunikasi, int semester)
        {
            return hasilKomunikasi = komunikasi * 6 * semester;
        }

        public double hitungKuliah(double kuliah, int semester)
        {
            return hasilKuliah = kuliah * semester;
        }

        public double hitungBuku(double buku, int semester)
        {
            return hasilBuku = buku * semester;
        }

    }
}
