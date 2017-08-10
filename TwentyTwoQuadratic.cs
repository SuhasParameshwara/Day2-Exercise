using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyTwoQuadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float a, b, c;
                double FirstRoot, SecondRoot, determinant;
                Console.WriteLine("Enter the value of a:\n");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the value of b:\n");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the value of c:\n");
                c = float.Parse(Console.ReadLine());
                determinant = (b * b) - (4 * a * c);
                if(determinant > 0)
                {
                    Console.WriteLine("\nRoots are real and unequal.");
                    FirstRoot = (-b + Math.Sqrt(determinant)) / (2 * a);
                    SecondRoot = (-b - Math.Sqrt(determinant)) / (2 * a);
                    Console.WriteLine("\nFirst root is : " + FirstRoot);
                    Console.WriteLine("\nSecond root is : " + SecondRoot);
                }
                else if(determinant == 0)
                {
                    Console.WriteLine("\nRoots are real and equal.");
                    FirstRoot = (-b + Math.Sqrt(determinant)) / (2 * a);
                    Console.WriteLine("\nRoot: " + FirstRoot);
                }
                else
                {
                    Console.WriteLine("\nRoots are imaginary");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number.");
            }
            Console.ReadLine();
        }
    }
}
