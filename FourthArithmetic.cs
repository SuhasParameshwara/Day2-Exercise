using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthArithmetic

{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = ' ';
            do
            {
                try
                {
                    Console.WriteLine("Enter the two numbers: \n");
                    float FirstNum = float.Parse(Console.ReadLine());
                    float SecondNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your choice: \n1. Addition\n2. Subtraction\n3. Multiplication\n4.Division\n");
                    byte choice = byte.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("The sum of two numbers are {0}", FirstNum + SecondNum);
                            break;
                        case 2:
                            Console.WriteLine("The difference between two numbers are {0}", FirstNum - SecondNum);
                            break;
                        case 3:
                            Console.WriteLine("The product of two numbers are {0}", FirstNum * SecondNum);
                            break;
                        case 4:
                            if (SecondNum == 0)
                            {
                                Console.WriteLine("The number cannot be divided by zero!");
                            }
                            else
                            {
                                Console.WriteLine("The division of two numbers are {0}", FirstNum / SecondNum);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Number!");
                }
                Console.WriteLine("Do you wish to continue?(Y/N)");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y' || ch == 'Y'));
            Console.ReadKey();
        }
    }
}
