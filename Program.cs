using System;
/*
Created BY Adin Syahputra
*/
namespace daspro
{
    class Program
    {
        static void Main(string[] args)
        { //deklarasi variabel
            const int a = 3;
            const int b = 2;
            const int c = 1;
           
            int tambah = a+b+c;
            int kali = a*b*c;
            int kurang = a-b-c;
            int bagi = a/b/c;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine(" Password terdiri dari 3 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + tambah);
            Console.WriteLine("- Jika dikalikan hasilnya " + kali);
            Console.WriteLine("- Jika dikurangi hasilnya " + kurang);
            Console.WriteLine("- Jika dibagi hasilnya " + bagi);
            Console.WriteLine("");
            Console.WriteLine("Enter Code 1 :");
            string jawaban1 = Console.ReadLine();
            Console.WriteLine("Enter Code 2 :");
            string jawaban2 = Console.ReadLine();
            Console.WriteLine("Enter Code 3 :");
            string jawaban3 = Console.ReadLine();
            int jawaban11 = Int32.Parse(jawaban1);
            int jawaban22 = Int32.Parse(jawaban2);
            int jawaban33 = Int32.Parse(jawaban3);
            if (jawaban11 == a && jawaban22 == b && jawaban33 == c)
            Console.WriteLine("Kode Benar, Selamat Datang..");

            else
            { Console.WriteLine("Kode Salah, Silahkan coba lagi");
                
            }
        

            Console.Write("press any key to continue...");
        }
    }
}
