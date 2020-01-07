using System;
using System.Threading;

namespace Project_4
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();
                Console.WriteLine("Player1: X and Player2: O");
                Console.WriteLine("\n");

                Console.WriteLine((player % 2 == 0) ? "Player 2 turn\n" : "Player 1 turn\n");
                Board();
                Int32.TryParse(Console.ReadLine(), out choice);  

                if(choice < 1 || choice > 9) {
                    Console.WriteLine("Incorrect input, try again.");
                    Thread.Sleep(2000);
                } else if (arr[choice] != 'X' && arr[choice] != 'O') {
                    arr[choice] = player % 2 == 0 ? 'O' : 'X';
                    player++;
                } else  {
                    Console.WriteLine("Sorry the squer {0} is already filled.", choice);
                    Thread.Sleep(2000);
                }
                flag = CheckWin();

            } while (flag != 1 && flag != -1); 

            Console.Clear();
            Board();  

            if (flag == 1) 
            {
                Console.WriteLine("Player {0} won", (player % 2) + 1);
            }  else {
                Console.WriteLine("Draw");
            }

            Console.ReadLine();

        }

        private static void Board()

        {
            string format = "   {0}  |  {1}  |  {2}   ";
            string separator = "-------------------";
            Console.WriteLine(format , arr[1], arr[2], arr[3]);
            Console.WriteLine(separator);
            Console.WriteLine(format , arr[4], arr[5], arr[6]);
            Console.WriteLine(separator);
            Console.WriteLine(format , arr[7], arr[8], arr[9]);

        }

        private static int CheckWin()

        {

            if (arr[1] == arr[2] && arr[2] == arr[3]) {
                return 1;
            } else if (arr[4] == arr[5] && arr[5] == arr[6]) {
                return 1;
            } else if (arr[6] == arr[7] && arr[7] == arr[8]) {
                return 1;
            }  else if (arr[1] == arr[4] && arr[4] == arr[7]) {
                return 1;
            } else if (arr[2] == arr[5] && arr[5] == arr[8]) {
                return 1;
            } else if (arr[3] == arr[6] && arr[6] == arr[9]) {
                return 1;
            } else if (arr[1] == arr[5] && arr[5] == arr[9]) {
                return 1;
            } else if (arr[3] == arr[5] && arr[5] == arr[7]) {
                return 1;
            } else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9') {
                return -1;
            } else {
                return 0;
            }

        }
    }
}
