using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n################################");
            Console.WriteLine("1. Numbrid mis jagunevad kolmega:");
            for (int i = 1; i < 101; i++) {
                if(i % 3 == 0) {
                    Console.WriteLine(i);
                    }
            }
        }
    }
}
