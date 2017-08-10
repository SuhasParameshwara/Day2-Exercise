using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                try {
                    Console.WriteLine("Enter the three Characters: \n");
                    char FirstChar = ' ';
                    char SecondChar = ' ';
                    char ThirdChar = ' ';
                    bool status = true;
                    while (status)
                    {
                        FirstChar = char.Parse(Console.ReadLine());
                        if (!char.IsDigit(FirstChar))
                        {
                            count++;
                            status = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Character!\nPlease enter a valid character!");
                        }
                    }
                    status = true;
                    while (status)
                    {
                        SecondChar = char.Parse(Console.ReadLine());
                        if (!char.IsDigit(SecondChar))
                        {
                            count++;
                            status = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Character!\nPlease enter a valid character!");
                        }
                    }
                    status = true;
                    while (status)
                    {
                        ThirdChar = char.Parse(Console.ReadLine());
                        if (!char.IsDigit(ThirdChar))
                        {
                            count++;
                            status = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Character!\nPlease enter a valid character!");
                        }
                    }
                    Console.WriteLine("The three characters are {0} {1} {2}", ThirdChar, SecondChar, FirstChar);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Character!");
                } 
            } while (count != 3);
            Console.ReadLine();
        }
    }
}
