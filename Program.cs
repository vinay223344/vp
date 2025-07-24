using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 10;
            Program p = new Program();

            // Pre-increment operation
            num2 = ++num1;
            Console.Write("Case-1\n");
            Console.Write("n1=" + num1 + "\n" + "n2=" + num2 + "\n");

            // Post-increment operation
            num2 = num1++;
            Console.Write("Case-2\n");
            Console.Write("n1=" + num1 + "\n" + "n2=" + num2 + "\n");
            // Swapping values
            p.swapping(ref num1, ref num2);
            Console.Write("Case-3\n");
            Console.Write("n1=" + num1 + "\n" + "n2=" + num2 + "\n");
        }
        void swapping(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("Swapped In Function\n");
        }
    }
}
