using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyNineElectricity
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = ' ';
            do
            {
                try
                {
                    Console.WriteLine("Enter the customer id: \n");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter the customer name: \n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter the units: \n");
                    int unit = int.Parse(Console.ReadLine());
                    if (unit >= 1 && unit <= 100)
                    {
                        Console.WriteLine("\nThe amount due is Rs. 0");
                    }
                    else if (unit > 100 && unit <= 200)
                    {
                        Console.WriteLine("\nThe amount due is Rs. {0}", unit * 1.5);
                    }
                    else if (unit > 200 && unit <= 300)
                    {
                        Console.WriteLine("\nThe amount due is Rs. {0}", unit * 2);
                    }
                    else if (unit > 300 && unit <= 400)
                    {
                        Console.WriteLine("\nThe amount due is Rs. {0}", unit * 3);
                    }
                    else if (unit > 400 && unit <= 500)
                    {
                        Console.WriteLine("\nThe amount due is Rs. {0}", unit * 4);
                    }
                    else if (unit > 500)
                    {
                        Console.WriteLine("\nThe amount due is Rs. {0}", unit * 6);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong Format");
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                ch = char.Parse(Console.ReadLine());
            } while (ch != 'n' && ch != 'N');
        }
    }
}
