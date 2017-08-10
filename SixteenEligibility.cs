using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixteenEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number: \n");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("He/She is eligible to vote.");
                }
                else
                {
                    Console.WriteLine("He/She is not eligible to vote.");
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
