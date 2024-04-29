using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rival_Achmad_Firdaus_Kuis_1_Protop
{
    internal class WeaponProduct
    {
        public string Nama { get; set; }
        public double Harga { get; set; }
        public int Stok { get; set; }

        public WeaponProduct(string nama, double harga, int stok)
        {
            Nama = nama;
            Harga = harga;
            Stok = stok;
        }

        public override string ToString()
        {
            return $"Nama: {Nama}, Harga: Rp. {Harga}, Stok: {Stok}";
        }
    }
}
