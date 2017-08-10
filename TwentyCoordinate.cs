using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyCooridnate
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the Xcoordinate: \n");
                float xCoord = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the Ycoordinate: \n");
                float yCoord = float.Parse(Console.ReadLine());
                if (xCoord > 0 && yCoord > 0)
                {
                    Console.WriteLine("\nThe point ({0},{1}) lies in the first quadrant.", xCoord, yCoord);
                }
                else if (xCoord < 0 && yCoord > 0)
                {
                    Console.WriteLine("\nThe point ({0},{1}) lies in the second quadrant.", xCoord, yCoord);
                }
                else if (xCoord < 0 && yCoord < 0)
                {
                    Console.WriteLine("\nThe point ({0},{1}) lies in the third quadrant.", xCoord, yCoord);
                }
                else if (xCoord > 0 && yCoord < 0)
                {
                    Console.WriteLine("\nThe point ({0},{1}) lies in the fourth quadrant.", xCoord, yCoord);
                }
                else if(xCoord == 0 && yCoord == 0)
                {
                    Console.WriteLine("\nThe point (0,0) lies in the centre.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Input!");
            }
            Console.ReadLine();
        }
    }
}
