using System;
 //Dibuat Oleh : ADIN SYAHPUTRA
 
namespace Daspro
{
    class Dice
    { 
            static int Ronde = 1;
            static int skorkomputer, skoranda;


        static void Main(string[] args)
        {  
            Intro();
            for (Ronde = 1; Ronde < 10; Ronde++)
            {

                Playgame();
                if(skoranda < skorkomputer){
                    Console.WriteLine("Selamat! Komputer menang");
                }
            }
        {
                    Console.WriteLine();
                    Console.WriteLine("Skor Akhir Komputer " + skorkomputer+ "\nSkor Akhir Anda " + skoranda);
                }
            Console.WriteLine("\nPermainan Selesai");
            if(skoranda > skorkomputer){
                    Console.WriteLine("Selamat! Anda Menang ");
                    
                }
                else if(skorkomputer > skoranda)
                { 
                  Console.WriteLine("Komputer Menang"); 
                }
                else if(skorkomputer == skoranda)
                {
                    Console.WriteLine("Hasil Seri");
        }

        static void Intro()
        {
            Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde...");
            Console.WriteLine("");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang menang? Selamat berjuang");

        }

        static void Playgame(){ 
            int dadukomputer,daduanda;

            Random rng = new Random();
            dadukomputer = rng.Next(1,7);
            daduanda = rng.Next(1,7);
    
            
            Console.WriteLine("");

            Console.WriteLine("Ronde " + Ronde);
            Console.WriteLine("Nilai komputer : " + dadukomputer);
            Console.Write("\nLempar dadu anda : \n");
            Console.ReadKey();
            Console.WriteLine("Nilai anda : " + daduanda);

            if(dadukomputer > daduanda){
                Console.WriteLine("\nKomputer Menang...");
                skorkomputer +=1;

            }else if(daduanda > dadukomputer){
                Console.WriteLine();
                Console.WriteLine("Anda Menang");
                skoranda += 1;
            
            }else{
                Console.WriteLine();
                Console.WriteLine("Seri");
            } 
            Console.ReadKey();
        
            }
        }
    }
}
