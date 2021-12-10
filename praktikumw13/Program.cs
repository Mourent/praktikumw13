using System;
using System.Collections.Generic;

namespace praktikumw13
{
    class Program
    {
        static void Main(string[] args)
        { 
            int jumlahData = 0;
            Console.Write("Berapa data = ");
            int banyakData = Convert.ToInt32(Console.ReadLine());
            jumlahData += banyakData;
            var nim = new List<string>();
            var nama = new List<string>();
            var jenisKelamin = new List<string>();
            var tahunMasuk = new List<int>();
            var programStudi = new List<string>();
            var kelas = new List<string>();
            int counter = 1;
            while (true)
            {
                Console.WriteLine();
                for (int i = 0; i < banyakData; i++)
                {
                    Console.WriteLine("data ke - " + counter); counter++;
                    Console.Write("NIM            : ");
                    string nimBaruBiarGaBingung = Console.ReadLine();
                    for (int j=0; j<nim.Count; j++)
                    {
                        while (nim[j] == nimBaruBiarGaBingung)
                        {
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN!!!");
                            Console.Write("NIM            : ");
                            nimBaruBiarGaBingung = Console.ReadLine();
                        }
                    }
                    nim.Add(nimBaruBiarGaBingung);
                    Console.Write("NAMA           : ");
                    nama.Add(Console.ReadLine());
                    Console.Write("JENIS KELAMIN  : ");
                    jenisKelamin.Add(Console.ReadLine());
                    Console.Write("TAHUN MASUK    : ");
                    tahunMasuk.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("PROGRAM STUDI  : ");
                    programStudi.Add(Console.ReadLine());
                    Console.Write("KELAS          : ");
                    kelas.Add(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.Write("Print Hasil ? (y/n)");
                string print = Console.ReadLine();
                if (print == "y")
                {
                    Console.Clear();
                }
                else if (print == "n")
                {
                    System.Environment.Exit(1);
                }
                var sb = new System.Text.StringBuilder();
                sb.Append(String.Format("{0,-4} {1, -5} {2, -30} {3, -15} {4, -15} {5, -15} {6, -15}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS"));
                sb.Append("\n");
                for (int i = 0; i < jumlahData; i++)
                {
                    sb.Append(String.Format("{0,-4} {1, -5} {2, -30} {3, -15} {4, -15} {5, -15} {6, -15} \n", i + 1, nim[i], nama[i].ToUpper(), jenisKelamin[i].ToUpper(), tahunMasuk[i], programStudi[i].ToUpper(), kelas[i].ToUpper()));
                }
                Console.WriteLine(sb);
                Console.WriteLine();
                Console.Write("Tambah Data? (y/n)");
                string ulang = Console.ReadLine();
                if (ulang == "y")
                {
                    Console.Write("Berapa data = ");
                    banyakData = Convert.ToInt32(Console.ReadLine());
                    jumlahData += banyakData;
                }
                else if (ulang == "n")
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
