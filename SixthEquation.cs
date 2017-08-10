using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=-5; i<6; i++)
            {
                Console.WriteLine("When y = {0} the value of x = {1}", i, ((i * i) + (2 * i) + 1));
            }
            Console.ReadLine();
        }
    }
}
