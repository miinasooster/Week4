using System;

namespace PinKoodKolmeKatsega
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada PIN-koodi;
            //Programm võrdleb sisestatud PIN-Koodi arvuga 123;
            //kui sisestatud PIN-kood on 123, siis konsool kuvab ''Tere tulemast'';
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab ''Vale PIN. Proovi uuesti'';
            //Kasutajal on 3 katset;

            int i = 0;

            while (i < 3) 

            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                
                }

                else
                {
                    //i = i + 1;
                    i++;
                    Console.WriteLine($"Vale PIN, {3 - i} katset on jäänud!");
                }
            }



                Console.WriteLine("Kena päeva!");
        }
    }
}

