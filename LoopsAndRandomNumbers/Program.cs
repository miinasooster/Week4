using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada PIN-koodi;
            //Programm võrdleb sisestatud PIN-Koodi arvuga 123;
            //kui sisestatud PIN-kood on 123, siis konsool kuvab ''Tere tulemast'';
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab ''Vale PIN. Proovi uuesti'';
           

            Console.WriteLine("Sisesta PIN:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if (userPIN == 1234) 
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }

            Console.WriteLine("Kena päeva!");



        }
    }
}
