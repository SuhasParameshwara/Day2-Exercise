using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyFourMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the month number: \n");
                int num = int.Parse(Console.ReadLine());
                if(num > 12 && num < 1)
                {
                    Console.WriteLine("Invalid Month!");
                }
                else
                {
                    if(num == 2)
                    {
                        Console.WriteLine("If its a leap year it contains 29 days and if its not a leap year it conatins 28 days");
                    }
                    else
                    {
                        if(num % 2 != 0)
                        {
                            Console.WriteLine("This month consists of 31 days.");
                        }
                        else
                        {
                            Console.WriteLine("This month consists of 30 days.");
                        }
                    }
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
