using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiUas4385
{
    class Program
    {
        static List<Prodak> daftarProduk = new List<Prodak>();
        static Prodak Produk = new Prodak();

        static void Main(string[] args)
        {
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu 1-3: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;
                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: 
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilihan Menu\n");
            Console.WriteLine("1. Tambah produk");
            Console.WriteLine("2. Tampilkan produk");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Produk = new Prodak();
            Console.WriteLine("Tambah data prdoduk");
            Console.Write("Nota   : ");
            Produk.nota = Console.ReadLine();
            Console.Write("Tanggal   : ");
            Produk.Tanggal = Console.ReadLine();
            Console.Write("Jenis [T/K]  : ");
            string TK;
            TK = Console.ReadLine();
            if ( TK == "T")
            {
                Produk.Jenis = "Tunai";
            }
            else if (TK == "K")
            {
                Produk.Jenis = "Kredit";
            }
            Console.Write("Total   : ");
            Produk.Total = Console.ReadLine();
            daftarProduk.Add(Produk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
        static void TampilPenjualan()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Produk\n");
            foreach (Prodak objProd in daftarProduk)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4}", no, objProd.nota, objProd.Tanggal, objProd.Jenis, objProd.Total);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}