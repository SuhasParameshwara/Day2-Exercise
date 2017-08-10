using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool status = true;
            try
            {
                Console.WriteLine("------------Sign up Page-----------------\n");
                Console.Write("Username: ");
                string UserName = Console.ReadLine();
                Console.Write("Password: ");
                string PassWord = Console.ReadLine();
                Console.WriteLine("---------------Successfully Registered-------------\n");
                Console.WriteLine("------------------Log in Page-----------------\n");
                do
                {
                    Console.Write("Username: ");
                    string name = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine();
                    if (password.Equals(PassWord) && name.Equals(UserName))
                    {
                        Console.WriteLine("Logged in Successfully!");
                        status = false;
                    }
                    else
                    {
                        if (!password.Equals(PassWord) && !name.Equals(UserName))
                        {
                            Console.WriteLine("Error 404 : Invalid Username and Password!\n");
                            count++;
                        }
                        else if (!password.Equals(PassWord))
                        {
                            Console.WriteLine("Error 404 : Invalid Password!\n");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Error 404 : Invalid Username!\n");
                            count++;
                        }
                    }
                } while (count != 3 && status == true);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            if(count == 3)
            {
                Console.WriteLine("Sorry! Your account has been blocked! Report to Admin!");
            }
            Console.ReadLine();
        }
    }
}
