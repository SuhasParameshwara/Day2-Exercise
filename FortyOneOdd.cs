using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyOneOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of terms: \n");
                int num = int.Parse(Console.ReadLine());
                Console.Write("The first {0} odd numbers are ", num);
                for (int i = 1; i <= num; i++)
                {
                    Console.Write("{0}", ((2 * i) - 1));
                    Console.Write(" ");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid number!");
            }
            Console.ReadLine();
        }
    }
}
