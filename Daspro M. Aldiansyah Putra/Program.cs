using System;
 //Dibuat Oleh : ADIN SYAHPUTRA
 
namespace Daspro
{
    class Program
    { //New Work

        //Deklarasi Variabel
            static int kesempatan = 2;
            static int level = 1;
            static bool bGameSelesai = true;


        static void Main(string[] args)
        {  
            while (kesempatan > -1){  
                Intro();

                Playgame();

                if(level > 5){
                    Console.WriteLine("Menang! Anda adalah agen Rahasia");
                    break;
                }
                if(kesempatan < 1){
                    Console.WriteLine("\nKalah! Anda bukan agen Rahasia");
                }

            }
            Console.WriteLine("\nPermainan Selesai");

        }

        static void Intro(){
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui");
        }

        static void Playgame(){ 
            int KodeA;
            int KodeB;
            int KodeC;
            int jumlahkode;
            string TebakanA;
            string TebakanB;
            string TebakanC;
                   
            int hasiltambah;
            int hasilkali;

            Random rng = new Random();

            KodeA = rng.Next(1,level + 1);
            KodeB = rng.Next(1,level + 1);
            KodeC = rng.Next(1,level + 1);

            jumlahkode = 3;

            //Aritmatika
            hasiltambah = KodeA + KodeB + KodeC;
            hasilkali = KodeA * KodeB * KodeC;
            
            Console.WriteLine("");

            Console.WriteLine("Level " + level);
            Console.WriteLine("- Password terdiri dari "+jumlahkode+" angka");
            Console.WriteLine("- jika ditambahkan hasilnya "+ hasiltambah);
            Console.WriteLine("- jika dikalikan hasilnya "+ hasilkali);

            //Tebakan
            Console.Write("\nMasukkan Kode Pertama : ");
            TebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode Kedua : ");
            TebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode Ketiga : ");
            TebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+TebakanA+", "+TebakanB+", "+TebakanC+"?");

            if(TebakanA == KodeA.ToString() && TebakanB == KodeB.ToString() && TebakanC == KodeC.ToString()){
                Console.WriteLine("\nTebakan Anda Benar...");
                //tambah level
                level += 1;

            }else{
                Console.WriteLine("");
                Console.WriteLine("Tebakan Anda Salah... Silahkan Coba lagi");

                //kurang kesempatan
                Console.WriteLine("Kesempatan " +kesempatan);
                kesempatan = kesempatan - 1;
            }

        }
    }
}
