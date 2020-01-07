using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n################################\n");
            Console.WriteLine("2. Lase kasutajal sisestada arve kuni tühi string vastuseks tuleb (ehk ENTER ilma midagi kirjutamata). Arvuta nende arvude summa ning min ja max väärtused. Trüki saadud tulemused ekraanile");
            
            List<int> numbers = new List<int>();
            string number;
            string sumValue = "0.0";
            string minValue = "0.0";
            string maxValue = "0.0";
            while (true)
            {
                number = Console.ReadLine();
                if (number == "")
                {
                    if(numbers.Count > 0) {
                        sumValue = String.Format("{0:0.00}", numbers.Sum());
                        maxValue = String.Format("{0:0.00}", numbers.Max());
                        minValue = String.Format("{0:0.00}", numbers.Min());
                    }

                    Console.WriteLine("Sisestatud numbrite summa: {0}, max: {1}, min {2}.", sumValue, minValue, maxValue);
                    break;
                }
                else {
                    numbers.Add(Convert.ToInt32(number));
                }
                
            }
        }
    }
}
