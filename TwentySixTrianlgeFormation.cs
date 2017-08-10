using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentySixTriangleFormation
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the three angles of a traingle\n");
                Console.WriteLine("Enter the first angle: \n");
                int FirstAngle = int.Parse(Console.ReadLine());
                while(FirstAngle < 0)
                {
                    Console.WriteLine("\nAngle cannot be negative! Please enter a positive value!\n");
                    FirstAngle = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nEnter the second angle: \n");
                int SecondAngle = int.Parse(Console.ReadLine());
                while(SecondAngle < 0)
                {
                    Console.WriteLine("\nAngle cannot be negative! Please enter a positive value!\n");
                    SecondAngle = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nEnter the third angle: \n");
                int ThirdAngle = int.Parse(Console.ReadLine());
                while (ThirdAngle < 0)
                {
                    Console.WriteLine("\nAngle cannot be negative! Please enter a positive value!\n");
                    ThirdAngle = int.Parse(Console.ReadLine());
                }
                if (FirstAngle + SecondAngle + ThirdAngle == 180)
                {
                    Console.WriteLine("\nIt is valid triangle");
                }
                else
                {
                    Console.WriteLine("\nIt is not a valid triangle");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid angle!");
            }
            Console.ReadLine();
        }
    }
}
