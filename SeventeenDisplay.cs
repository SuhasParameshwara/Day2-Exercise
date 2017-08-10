using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventeenDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine("Enter the number:\n");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("\nSince m > 0 , n = 1");
                }
                else if (num == 0)
                {
                    Console.WriteLine("\nSine m = 0, n = 0");
                }
                else
                {
                    Console.WriteLine("\nSince m < 0, n = -1");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Number!");
            }
            Console.ReadLine();
        }
    }
}
