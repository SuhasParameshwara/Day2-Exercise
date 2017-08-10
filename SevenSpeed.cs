using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the distance:\n");
                float distance = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the time taken:\n");
                float time = float.Parse(Console.ReadLine());
                float kph = (distance / 1000.0f) / (time / 3600.0f);
                float mph = kph / 1.609f;

                Console.WriteLine("Speed in km/h is {0}", kph);
                Console.WriteLine("Speed in mp/h is {0}", mph);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
