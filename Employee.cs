using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Employee
    {
        string emp_name;
        int bas_sal;
        int HRA;
        int DA;
        int GDP ;
        int TAX ;
        double NS ;
        Employee()
        {
            Console.WriteLine("Employee Name :");
            emp_name = Console.ReadLine();
            Console.WriteLine("Base sal :");
            bas_sal= int.Parse(Console.ReadLine());
            HRA = bas_sal * 15 / 100;
            DA = bas_sal * 10 / 100;
            GDP = bas_sal + HRA + DA;
            TAX = GDP * 8 / 100;
            NS = GDP - TAX;
        }
        void Display()
        {
            Console.WriteLine("Employee Name :" + emp_name);
            Console.WriteLine("Base Salary :" + bas_sal);
            Console.WriteLine("HRA :" + HRA);
            Console.WriteLine("DA :" + DA);
            Console.WriteLine("GDP :" + GDP);
            Console.WriteLine("TAX :" + TAX);
            Console.WriteLine("NS :" + NS);
        }
        static void Main()
        {

            Employee e = new Employee();
            e.Display();
        }
    }
}
