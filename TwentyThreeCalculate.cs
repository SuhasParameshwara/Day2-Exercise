using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyThreeCalculate
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
                    Console.WriteLine("Enter the name of the student: \n");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter the roll number of the {0}: \n", name);
                    string RollNum = Console.ReadLine();
                    Console.WriteLine("Enter the mark in Physics: \n");
                    int PhyMark = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the mark in Chemistry: \n");
                    int ChemMark = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the mark in Maths: \n");
                    int MatMark = int.Parse(Console.ReadLine());
                    Console.WriteLine("The total of Marks in all the subjects are {0}", PhyMark + ChemMark + MatMark);
                    Console.WriteLine("The average Mark is {0}", (PhyMark + ChemMark + MatMark) / 3);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Number!");
                }
                Console.WriteLine("Do you want to continue: (Y/N)");
                ch = char.Parse(Console.ReadLine());
            } while (ch != 'n' && ch != 'N');
        }
    }
}
