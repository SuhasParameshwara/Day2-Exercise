using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineteenLargestThree
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the three numbers: \n");
                float FirstNumber = float.Parse(Console.ReadLine());
                float SecondNumber = float.Parse(Console.ReadLine());
                float ThirdNumber = float.Parse(Console.ReadLine());
                if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
                {
                    Console.WriteLine("{0} is the greatest among the three numbers", FirstNumber);
                }
                else if (SecondNumber > ThirdNumber)
                {
                    Console.WriteLine("{0} is the greatest among the three numbers", SecondNumber);
                }
                else
                {
                    Console.WriteLine("{0} is the greatest among the three numbers", ThirdNumber);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
