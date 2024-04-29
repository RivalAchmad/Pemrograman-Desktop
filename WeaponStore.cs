using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rival_Achmad_Firdaus_Kuis_1_Protop
{
    internal class WeaponStore
    {
        private List<WeaponProduct> Produk = new List<WeaponProduct>();

        public void TambahProduk(WeaponProduct produk)
        {
            Produk.Add(produk);
        }

        public void HapusProduk(string namaProduk)
        {
            WeaponProduct productToRemove = Produk.Find(p => p.Nama.Equals(namaProduk, StringComparison.OrdinalIgnoreCase));
            if (productToRemove != null)
            {
                Produk.Remove(productToRemove);
                Console.WriteLine("Produk berhasil dihapus.");
            }
            else
            {
                Console.WriteLine("Produk tidak ditemukan.");
            }
        }

        public void CariNama(string nama)
        {
            var temukanProduk = Produk.Where(p => p.Nama.ToLower().Contains(nama.ToLower())).ToList();
            if (temukanProduk.Any())
            {
                foreach (var produk in temukanProduk)
                {
                    Console.WriteLine(produk);
                }
            }
            else
            {
                Console.WriteLine("Produk tidak ditemukan.");
            }
        }

        public void CariHarga(double minPrice, double maxPrice)
        {
            var temukanProduk = Produk.Where(p => p.Harga >= minPrice && p.Harga <= maxPrice).ToList();
            if (temukanProduk.Any())
            {
                foreach (var produk in temukanProduk)
                {
                    Console.WriteLine(produk);
                }
            }
            else
            {
                Console.WriteLine("Produk dengan kisaran harga tersebut tidak ditemukan.");
            }
        }

        public void UrutkanStok()
        {
            var sortedProducts = Produk.OrderBy(p => p.Stok).ToList();
            foreach (var produk in sortedProducts)
            {
                Console.WriteLine(produk);
            }
        }
    }
}
