﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortyTwoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
