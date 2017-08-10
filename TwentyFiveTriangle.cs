using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFiveTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the length of the three sides of the triangle:\n");
                Console.WriteLine("Enter the lenght of the first side: \n");
                int FirstLen = int.Parse(Console.ReadLine());
                while(FirstLen < 0)
                {
                    Console.WriteLine("Length cannot be negative! Please enter a postive value!");
                    FirstLen = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the lenght of the second side: \n");
                int SecondLen = int.Parse(Console.ReadLine());
                while (SecondLen < 0)
                {
                    Console.WriteLine("Length cannot be negative! Please enter a postive value!");
                    SecondLen = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the length of the third side: \n");
                int ThirdLen = int.Parse(Console.ReadLine());
                while (ThirdLen < 0)
                {
                    Console.WriteLine("Length cannot be negative! Please enter a postive value!");
                    ThirdLen = int.Parse(Console.ReadLine());
                }
                if (FirstLen == SecondLen && FirstLen == ThirdLen && SecondLen == ThirdLen)
                {
                    Console.WriteLine("It is a Equilateral triangle.");
                }
                else if (FirstLen != SecondLen && FirstLen != ThirdLen && SecondLen != ThirdLen)
                {
                    Console.WriteLine("It is a Scalene triangle.");
                }
                else
                {
                    Console.WriteLine("It is an Isoceles triangle.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
