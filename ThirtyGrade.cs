using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do {
                try
                {
                    Console.WriteLine("Enter the grade of the student: \n");
                    char grade = char.Parse(Console.ReadLine());
                    if (grade == 'E' || grade == 'e')
                    {
                        Console.WriteLine("E = Excellent.");
                    }
                    else if (grade == 'V' || grade == 'v')
                    {
                        Console.WriteLine("V = Very Good.");
                    }
                    else if (grade == 'G' || grade == 'g')
                    {
                        Console.WriteLine("G = Good.");
                    }
                    else if (grade == 'a' || grade == 'A')
                    {
                        Console.WriteLine("A = Average.");
                    }
                    else if (grade == 'f' || grade == 'F')
                    {
                        Console.WriteLine("F = Fail.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Grade!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Grade!");
                }
                Console.WriteLine("Do you want to continue? (Y/N)\n");
                choice = Console.ReadLine();
            } while (!choice.Equals("N") && !choice.Equals("n"));
        }
    }
}
