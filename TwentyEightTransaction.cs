using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyEightTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                float CostPrice, SellingPrice;
                Console.WriteLine("Enter the cost price: \n");
                CostPrice = float.Parse(Console.ReadLine());
                while (CostPrice < 0)
                {
                    Console.WriteLine("\nCost Price cannot be negative!Please enter a positive value!");
                    CostPrice = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nEnter the selling price: \n");
                SellingPrice = float.Parse(Console.ReadLine());
                while (SellingPrice < 0)
                {
                    Console.WriteLine("\nSelling Price cannot be negative!Please enter a positive value!");
                    SellingPrice = float.Parse(Console.ReadLine());
                }
                if (SellingPrice > CostPrice)
                {
                    Console.WriteLine("\nProfit Amount: Rs. {0}.", SellingPrice - CostPrice);
                }
                else if (CostPrice > SellingPrice)
                {
                    Console.WriteLine("\nLoss Amount: Rs. {0}.", CostPrice - SellingPrice);
                }
                else
                {
                    Console.WriteLine("\nNo profit nor loss.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Number!");
            }
            Console.ReadLine();
        }
    }
}
