using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the temperature in centigrade: \n");
                float temp = float.Parse(Console.ReadLine());
                if(temp < 0)
                {
                    Console.WriteLine("The climate is Freezing Weather.");
                }
                else if(temp>=0 && temp < 10)
                {
                    Console.WriteLine("The climate is Very Cold Wather.");
                }
                else if(temp>=10 && temp < 20)
                {
                    Console.WriteLine("The climate is Cold Weather.");
                }
                else if(temp>=20 && temp < 30)
                {
                    Console.WriteLine("The climate is Normal.");
                }
                else if(temp>=30 && temp < 40)
                {
                    Console.WriteLine("The climate is Hot.");
                }
                else if(temp >= 40)
                {
                    Console.WriteLine("The climate is Very Hot");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Temperature!");
            }
        }
    }
}
