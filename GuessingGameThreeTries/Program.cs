using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri (1-10);
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suudab numbri ära arvata, siis kasutaja on mängu võitnud;
            //kasutajal on 3 katset;
            //programm genereerib juhuslikud numbrid vaid ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            while (i < 3)
            {

                Console.WriteLine("Sisesta number 1-10");

                int userRandomNumber = Convert.ToInt32(Console.ReadLine());

                if (userRandomNumber ==cpuNumber)

                {
                    Console.WriteLine("Olete võitja!");
                    break;
                }


                else

                {
                    i++;
                    Console.WriteLine($"Vale, {3 - i} katset on jäänud");
                }


                Console.WriteLine("Arvuti võit!");
            }






        }
    }
}
