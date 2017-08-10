using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyOneDay
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the day number: \n");
                int DayNumber = int.Parse(Console.ReadLine());
                switch (DayNumber)
                {
                    case 1: Console.WriteLine("\nThe first day is Sunday.");
                        break;
                    case 2: Console.WriteLine("\nThe second day is Monday.");
                        break;
                    case 3: Console.WriteLine("\nThe third day is Tuesday.");
                        break;
                    case 4: Console.WriteLine("\nThe fourth day is Wednesday.");
                        break;
                    case 5: Console.WriteLine("\nThe fifth day is Thursday.");
                        break;
                    case 6: Console.WriteLine("\nThe sixth day is Friday.");
                        break;
                    case 7: Console.WriteLine("\nThe seventh day is Saturday.");
                        break;
                    default: Console.WriteLine("\nInvalid Day Number!");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Day Number!");
            }
            Console.ReadLine();
        }
    }
}
