using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the year:\n");
                int year = int.Parse(Console.ReadLine());
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    Console.WriteLine("\nYear " + year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine("\nYear " + year + " is not a leap year.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Year!");
            }
            Console.ReadLine();
        }
    }
}
