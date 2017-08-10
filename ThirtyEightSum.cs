using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyEightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of terms: \n");
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine("Number: {0}", i);
                    sum = sum + i;
                }
                Console.WriteLine("The sum of natural numbers till {0} is {1}", num, sum);
            }
            catch (Exception e) {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
