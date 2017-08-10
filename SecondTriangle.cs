using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number: \n");
                float num = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the triangle: \n");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine();
                for(int i=0; i<width; i++)
                {
                    for(int j=0; j<=i; j++)
                    {
                        Console.Write("{0} ", num);
                    }
                    Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid number!");
            }
            Console.ReadKey();
        }
    }
}
