using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the  marks in Maths: \n");
                float MatMark = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the marks in Physics: \n");
                float PhyMark = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the marks in Chemistry: \n");
                float ChemMark = float.Parse(Console.ReadLine());
                if (MatMark >= 65 && PhyMark >= 55 && ChemMark >= 50 && MatMark + ChemMark + PhyMark >= 180)
                {
                    Console.WriteLine("\nHe/She is eligible for the admission.");
                }
                else
                {
                    Console.WriteLine("\nHe/She is not eligible for the admission.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Number.");
            }
            Console.ReadLine();
        }
    }
}
