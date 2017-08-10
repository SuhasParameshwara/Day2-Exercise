using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightSphere
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the radius of the sphere: \n");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Surface Area of the Sphere: {0}", 3 * 3.14 * radius * radius);
                Console.WriteLine("Volume of the Sphere: {0}", 1.333 * 3.14 * radius * radius * radius);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Radius!");
            }
            Console.ReadLine();
        }
    }
}
