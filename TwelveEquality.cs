using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the two numbers: \n");
                int FirstNum = int.Parse(Console.ReadLine());
                int SecondNum = int.Parse(Console.ReadLine());
                if(FirstNum == SecondNum)
                {
                    Console.WriteLine("The entered two numbers are equal.");
                }
                else
                {
                    Console.WriteLine("The entered two numbers are not equal.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Integer!");
            }
            Console.ReadLine();
        }
    }
}
