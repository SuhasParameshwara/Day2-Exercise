using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyNineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the 10 numbers\n");
                int num = 0, sum = 0, count = 0;
                while (count < 10)
                {
                    num = int.Parse(Console.ReadLine());
                    sum = sum + num;
                    count++;
                }
                Console.WriteLine(sum);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
