using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Class1
    {
        static void Main() 
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Username");
                String username = Console.ReadLine();
                Console.WriteLine("Password");
                String password = Console.ReadLine();
                if (username == "184" && password == "hello")
                {
                    Console.WriteLine("Login sucessful");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Mail or Password");
                    Console.WriteLine("Please Enter correct details");
                }
            }
        }
    }
}
