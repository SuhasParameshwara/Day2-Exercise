﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyFourPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine("Enter the number of rows\n");
            int num = int.Parse(Console.ReadLine());
            for(int i=1; i<=num; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
