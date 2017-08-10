using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the radius of the circle: \n");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("\nArea of a Circle = {0}\nPerimeter of a Circle = {1}", 3.14 * radius * radius, (3.14 * (radius + radius))); 
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
