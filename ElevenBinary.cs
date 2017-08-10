using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter a number:\n");
                int num = int.Parse(Console.ReadLine());
                Stack<int> st = new Stack<int>();
                while (num != 0)
                {
                    st.Push(num % 2);
                    num /= 2;
                }
                int size = st.Count;
                while (size != 0)
                {
                    Console.Write(st.Pop());
                    size--;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid format!");
            }
            Console.ReadLine();
        }
    }
}
