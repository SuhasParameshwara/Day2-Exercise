using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthSymbolCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the character(If it's a letter enter in lowercase):\n");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("\nThe entered character is a vowel.");
                }
                else if (char.IsDigit(ch))
                {
                    Console.WriteLine("\nThe entered character is a digit.");
                }
                else
                {
                    if (char.IsUpper(ch))
                    {
                        Console.WriteLine("\nUpper case letters are not supported.");
                    }
                    else
                    {
                        Console.WriteLine("\nThe entered character is neither a vowel nor a digit.");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Character!");
            }
            Console.ReadLine();
        }
    }
}
