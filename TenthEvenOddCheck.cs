using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthEvenOddCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the twp numbers: \n");
                float FirstNum = float.Parse(Console.ReadLine());
                float SecondNum = float.Parse(Console.ReadLine());
                Console.WriteLine((FirstNum % 2 == 0 && SecondNum % 2 == 0) ? "\nTrue" : "\nFalse");
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number.");
            }
            Console.ReadLine();
        }
    }
}
