using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> Penjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi!\n\n");
            Console.WriteLine("1.Tambah Penjualan\n");
            Console.WriteLine("2.Tampilkan Penjualan\n");
            Console.WriteLine("3 .exit");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.WriteLine("Nota ke: "); string nota = Console.ReadLine();
            Console.WriteLine("Tanggal: "); string tanggal = Console.ReadLine();
            Console.WriteLine("Nama: "); string nama = Console.ReadLine();
            Console.WriteLine("Jenis (T/K):"); string jenis = Console.ReadLine();
            if (jenis == "t" || jenis == "T")
            {
                jenis = "Tunai";
            }
            else if (jenis == "K" || jenis == "k")
            {
                jenis = "kredit";
            }
            Console.WriteLine("Total Nota: ");
            int total = Convert.ToInt32(Console.ReadLine());
            Penjualan.Add(new Penjualan(nota, tanggal, nama, jenis,total));
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int counter = 1;
            Console.WriteLine("Data Penjualan !\n");
            foreach (Penjualan penjualan in Penjualan)
            {

                Console.WriteLine(counter + ". " + penjualan.nota + ", " + penjualan.tanggal + ", " + penjualan.nama + ", " + penjualan.jenis + ", " + penjualan.total);
                counter++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
