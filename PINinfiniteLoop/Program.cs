using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada PIN-koodi;
            //Programm võrdleb sisestatud PIN-Koodi arvuga 123;
            //kui sisestatud PIN-kood on 123, siis konsool kuvab ''Tere tulemast'';
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab ''Vale PIN. Proovi uuesti',
            //Katsete arv on piiramatu;

            bool loopActive = true;
            int i = 0;

            while (loopActive)

            {
                Console.WriteLine("Sisesta PIN:");
             int userPin = Convert.ToInt32(Console.ReadLine());

            if (userPin == 1234)

                {
                Console.WriteLine("Tere tulemast!");
                loopActive = false;
                }

            else
                {
                    i++;
                Console.WriteLine("Vale PIN, proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud");


                }



            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
