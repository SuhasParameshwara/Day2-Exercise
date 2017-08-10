using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number: \n");
                float num = float.Parse(Console.ReadLine());
                if(num >= 0)
                {
                    Console.WriteLine("{0} is a positive number.", num);
                }
                else
                {
                    Console.WriteLine("{0} is a negative number.", num);
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
