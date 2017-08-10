using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentySevenAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int flag = 0;
                do
                {
                    Console.WriteLine("\nEnter an alphabet: \n");
                    char ch = char.Parse(Console.ReadLine());
                    if ((((int)ch >= 97 && (int)ch <= 122) || ((int)ch >= 65 && (int)ch <= 90)))
                    {
                        flag = 1;
                        if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' ||
                           ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        {
                            Console.WriteLine("\n{0} is a vowel.", ch);
                        }
                        else
                        {
                            Console.WriteLine("\n{0} is a consonant.", ch);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Alphabet!");
                    }
                } while (flag != 1);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid character!");
            }
            Console.ReadLine();
        }
    }
}
