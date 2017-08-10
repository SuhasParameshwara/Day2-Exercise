using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyThreeMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the month number\n");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1: Console.WriteLine("The first month is January");
                            break;
                    case 2: Console.WriteLine("The second month is February");
                            break;
                    case 3: Console.WriteLine("The third month is March.");
                            break;
                    case 4: Console.WriteLine("The fourth month is April.");
                            break;
                    case 5: Console.WriteLine("The fifth month is May.");
                            break;
                    case 6: Console.WriteLine("The sixth month is June.");
                            break;
                    case 7: Console.WriteLine("The seventh month is July.");
                            break;
                    case 8: Console.WriteLine("The eight month is August.");
                            break;
                    case 9: Console.WriteLine("The ninth month is September.");
                            break;
                    case 10: Console.WriteLine("The tenth month is October.");
                            break;
                    case 11: Console.WriteLine("The eleventh month is Novemeber.");
                            break;
                    case 12: Console.WriteLine("The twelveth month is Decemeber.");
                            break;
                    default: Console.WriteLine("Invalid Input!");
                            break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid number!");
            }
            Console.ReadLine();
        }
    }
}
