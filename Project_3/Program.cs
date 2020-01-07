using System;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 50);
            int chances = 1;
            Console.WriteLine("\n################################\n");
            Console.WriteLine("Loome pisikese mängu, kus kas vastane või arvuti paneb esmalt kirja numbri vahemikus 1..50 ja seejärel püüame pakutud arvu ära arvata. Vastusena igale pakkumisele peame ütlema, kas tegu on pakutud arvuga, on see väiksem kui pakutu või suurem kui pakutu. Kui tühi string pannakse, katkestatakse mäng. Lõpuks teavitatakse mitu katset on tehtud ja kas õige tulemus leiti või mitte");
            Console.WriteLine("\n################################\n\n\n");
            Console.WriteLine("Arvuti valib numbri 1-50 vahel. Proovi see number ära arvata");
            while (true)
            {
                string guess = Console.ReadLine();
                if (guess == "")
                {
                    Console.WriteLine("Loobusid, sa proovisid {0} korda.", chances);
                    break;
                }
                else
                {
                    int guessInt = Convert.ToInt32(guess);
                    if (guessInt == randomNumber)
                    {
                        Console.WriteLine("Sa arvasid õigesti! Selleks kulus {0} katset.", chances);
                        break;
                    }
                    else if (randomNumber > guessInt)
                    {
                        Console.WriteLine("Sinu pakutud number on väiksem kui arvuti valitud number, proovi uuesti.");
                    }
                    else if (randomNumber < guessInt)
                    {
                        Console.WriteLine("Sinu pakutud number on suurem kui arvuti valitud number, proovi uuesti.");
                    }
                }
                chances++;
            }

        }
    }
}
