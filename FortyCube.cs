using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyCube
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of terms\n");
                float num = float.Parse(Console.ReadLine());
                for(int i=1; i<= num; i++)
                {
                    Console.WriteLine("Number: {0} and the cube of this number is: {1}", i, i * i * i);
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
