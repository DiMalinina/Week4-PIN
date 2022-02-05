using System;

namespace GuessingGameInfinite2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud
            //kasutajal on 3 katses, kui kasutaja ei ole suutnud 3 katsega numbrit ära arvata,
            //siis mängu võidab arvuti
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                

                if ( userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, sa võitsid!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number.Proovi uuesti. Sul on jäänud {3 - i } katset.");
                }

            }
            Console.WriteLine($"Juhuslik number oli: {cpuNumber}");
            Console.WriteLine("Kena päeva!");
        }
    }
}
