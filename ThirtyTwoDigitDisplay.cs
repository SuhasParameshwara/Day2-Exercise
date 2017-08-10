using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyTwoDigitDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a digit between 0 to 9: \n");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("\nThe entered digit is zero.");
                        break;
                    case 1:
                        Console.WriteLine("\nThe entered digit is one.");
                        break;
                    case 2:
                        Console.WriteLine("\nThe entered digit is two.");
                        break;
                    case 3:
                        Console.WriteLine("\nThe entered digit is three.");
                        break;
                    case 4:
                        Console.WriteLine("\nThe entered digit is four.");
                        break;
                    case 5:
                        Console.WriteLine("\nThe entered digit is five.");
                        break;
                    case 6:
                        Console.WriteLine("\nThe entered digit is six.");
                        break;
                    case 7:
                        Console.WriteLine("\nThe entered digit is seven.");
                        break;
                    case 8:
                        Console.WriteLine("\nThe entered digit is eigth.");
                        break;
                    case 9:
                        Console.WriteLine("\nThe entered digit is nine.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid number!");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid digit!");
            }
            Console.ReadLine();
        }
    }
}
