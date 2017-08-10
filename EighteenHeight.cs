using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EighteenHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the Height(In Centimetres): \n");
                float height = float.Parse(Console.ReadLine());
                if (height < 150.0)
                {
                    Console.WriteLine("\nDwarf.");
                }
                else if (height >= 150.0 && height <= 165.0)
                {
                    Console.WriteLine("\nAverage Height.");
                }
                else if (height >= 165.0 && height <= 195.0)
                {
                    Console.WriteLine("\nTaller.");
                }
                else
                {
                    Console.WriteLine("\nAbnormal Height.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Height!");
            }
            Console.ReadLine();
        }
    }
}
