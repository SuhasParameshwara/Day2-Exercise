using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyFiveArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = null;
            try {
                Console.WriteLine("Calculating area of various geometrical shapes\n");
                do {
                    Console.WriteLine("1. Square\n2. Rectangle\n3. Parallelogram\n4. Triangle\n5. Cirlce");
                    Console.WriteLine("Enter your choice: \n");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the length of side of a square: \n");
                            int len = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the square is {0}", len * len);
                            break;
                        case 2:
                            Console.WriteLine("Enter the length of the rectangle: \n");
                            int length = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the width of the rectangle: \n");
                            int width = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the rectangle is {0}", length * width);
                            break;
                        case 3:
                            Console.WriteLine("Enter the base of the parallelogram: \n");
                            int @base = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the height of the parallelogram: \n");
                            int height = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the parallelogram is {0}", @base * height);
                            break;
                        case 4:
                            Console.WriteLine("Enter the base of the triangle: \n");
                            int @baseTriangle = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the height of the triangle: \n");
                            int heightTriangle = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the triangle is {0}", @baseTriangle * (heightTriangle / 2));
                            break;
                        case 5:
                            Console.WriteLine("Enter the radius of the circle: \n");
                            int rad = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the circle is {0}", 3.14 * rad * rad);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                    Console.WriteLine("Do you want to continue? (Y/N)");
                    ch = Console.ReadLine();
                } while (!ch.Equals("N") && !ch.Equals("n"));
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
