using Rival_Achmad_Firdaus_Kuis_1_Protop;

class Program
{
    static void Main(string[] args)
    {
        WeaponStore store = new WeaponStore();

        store.TambahProduk(new WeaponProduct("AK-47", 8600000.0, 10));
        store.TambahProduk(new WeaponProduct("M16", 9700000.0, 8));
        store.TambahProduk(new WeaponProduct("MP5", 6500000.0, 15));
        store.TambahProduk(new WeaponProduct("M14", 10500000.0, 7));
        store.TambahProduk(new WeaponProduct("Glock", 3300000.0, 20));
        store.TambahProduk(new WeaponProduct("Dragunov SVD", 13000000.0, 5));

        Console.WriteLine("============================================");
        Console.WriteLine("= Selamat Datang di Toko Senjata Batujajar =");
        Console.WriteLine("============================================");
        Console.WriteLine("");
        Console.WriteLine("Lakukan login untuk masuk ke sistem");
        bool loggedIn = false;
        while (!loggedIn)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login berhasil.");
                loggedIn = true;
            }
            else
            {
                Console.WriteLine("Login gagal. Username atau password tidak valid. Silahkan coba kembali\n");
            }
        }

        bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cari berdasarkan nama");
                Console.WriteLine("2. Cari berdasarkan harga");
                Console.WriteLine("3. Urutkan produk berdasarkan jumlah stok");
                Console.WriteLine("4. Tambahkan produk baru");
                Console.WriteLine("5. Hapus Produk");
                Console.WriteLine("6. Keluar");
                Console.Write("Ketik pilihan anda: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Masukkan nama produk: ");
                        string nameToSearch = Console.ReadLine();
                        store.CariNama(nameToSearch);
                        break;
                    case 2:
                        Console.Write("Masukkan minimum harga: ");
                        double minPrice = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan maksimal harga: ");
                        double maxPrice = double.Parse(Console.ReadLine());
                        store.CariHarga(minPrice, maxPrice);
                        break;
                    case 3:
                        store.UrutkanStok();
                        break;
                    case 4:
                        Console.Write("Masukkan nama produk baru: ");
                        string namaProduk = Console.ReadLine();
                        Console.Write("Masukkan harga produk: ");
                        double productPrice = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan jumlah stok produk: ");
                        int productStock = int.Parse(Console.ReadLine());
                        store.TambahProduk(new WeaponProduct(namaProduk, productPrice, productStock));
                        Console.WriteLine("Produk berhasil ditambahkan.");
                        break;
                    case 5:
                        Console.Write("Masukkan nama produk untuk dihapus: ");
                        string productToRemove = Console.ReadLine();
                        store.HapusProduk(productToRemove);
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        
    }
}
