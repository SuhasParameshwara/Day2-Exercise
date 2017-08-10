using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFivePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows\n");
            int num = int.Parse(Console.ReadLine());
            int count = 1;
            for(int i=0; i<num; i++)
            {
                for(int j=0; j<= i; j++)
                {
                    Console.Write(count+" ");
                    count++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
