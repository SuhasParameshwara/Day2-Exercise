using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortySixPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, space, rows, k,temp=1;
            Console.WriteLine("Enter the number of rows\n");
            rows = int.Parse(Console.ReadLine());
            space = rows;
            for(i=1; i<= rows; i++)
            {
                for(k=0; k<=space; k++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(temp);
                }
                temp++;
                Console.WriteLine();
                space--;
            }
            Console.ReadLine();
        }
    }
}
