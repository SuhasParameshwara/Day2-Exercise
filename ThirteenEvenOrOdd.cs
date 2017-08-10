using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirteenEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number:\n");
                float num = float.Parse(Console.ReadLine());
                if(num%2 == 0)
                {
                    Console.WriteLine("{0} is an even number.",num);
                }
                else
                {
                    Console.WriteLine("{0} is an odd number.",num);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invlaid number!");
            }
            Console.ReadLine();
        }
    }
}
