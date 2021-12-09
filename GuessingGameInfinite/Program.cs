using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri (1-10)
            //kasutaja peab selle numbri ära arvama
            //kui kasutaja suudab numbri ära arvata, siis kasutaja on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhuslikud numbrid vaid ühe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool a = true;
            

            while (a)

            {
                Console.WriteLine("Sisesta juhuslik number 1-10:");
                int userRandomNumber = Convert.ToInt32(Console.ReadLine());
                
                if (userRandomNumber == cpuNumber)

                {
                    Console.WriteLine("Oled võitja");
                    a = false;

                }

            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
