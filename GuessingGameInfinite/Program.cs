using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
                int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, sa võitsid!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number. Proovi uuesti!");
                    Console.WriteLine($"Oled vale numbri {i} korda sisestanud.");
                }

            }

            Console.WriteLine($"Juhuslik number oli: {cpuNumber}");
            Console.WriteLine("Kena päeva!");


        }
    }
}
