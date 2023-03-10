using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static int kesempatan = 5;
        static String kataMisteri = "kucing";
        static List<string> listTebakan = new List<String>{};

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            Endgame();

        }

        static void Intro(){
            Console.WriteLine("Selamat datang hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu Punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan hewan");
            Console.WriteLine($"Kata tersebut terdiri dari {kataMisteri.Length} huruf");
            Console.WriteLine("Hewan Apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void PlayGame(){
                while(kesempatan>0){
                    Console.Write("Apa Huruf Tebakanmu?( pilih a-z) : ");
                    string input = Console.ReadLine();
                    listTebakan.Add(input);
                    if(CekJawaban(kataMisteri, listTebakan)){
                        Console.WriteLine("Selamat anda berhasil menebak katanya");
                        Console.WriteLine($"Kata misteri hari ini adalah {kataMisteri}");
                        break;
                    } else if(kataMisteri.Contains(input)){
                        Console.WriteLine("Huruf itu ada didalam kata ini");
                        Console.WriteLine("Silahkan tebak huruf lainnya...");
                        //Menampilkan huruf yang sudah tertebak
                        Console.WriteLine(CekHuruf(kataMisteri, listTebakan));
                    }else{
                        Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                        kesempatan--; //kesempatan = kesempatan - 1;
                        Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                    }
                    if(kesempatan == 0){
                        Endgame();
                        break;
                    }
                }
           }

        static bool CekJawaban(string kataRahasia, List<string> list){
            bool status = false;
            
            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if(list.Contains(c)){
                    status = true;
                }else{
                   return status = false;
                }
            }
            return status;
        }

         static string CekHuruf(string kataRahasia, List<string> list){
             string x = "";

             for (int i = 0; i < kataRahasia.Length; i++)
             {
                 string c = Convert.ToString(kataRahasia[i]);
                 if(list.Contains(c)){
                     x = x + c;
                 }else{
                     x = x + "_";
                 }
            }
            return x;
        }

        static void Endgame(){
            Console.WriteLine("Permainan berakhir");
            Console.WriteLine($"kata misteri sebenarnya adalah{kataMisteri}");
            Console.WriteLine("Byeee...");
        
        }
    }
}
