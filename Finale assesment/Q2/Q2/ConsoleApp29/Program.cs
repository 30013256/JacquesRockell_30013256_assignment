using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//jacques rockell
namespace ConsoleApp29
{
    class Program
    {
        static void Main()
        {
            //intro
            Console.WriteLine(".........................................................");
            Console.WriteLine(".............Welcome to staff payroll system.............");
            Console.WriteLine(".........................................................");
            //new employee created
            Employee e1 = new Employee();
            //asks for name
            Console.Write("Enter your name: ");
            e1.name = Console.ReadLine();
            //ask for anual gross
            Console.Write("Enter your anual gross: ");
            e1.annualGross = double.Parse(Console.ReadLine());

            Console.Write("Enter your tax rate: %");
            e1.taxRate = double.Parse(Console.ReadLine());

            Console.WriteLine("The net salary of " + e1.name + " is: " + e1.CalcNet());
            Console.ReadLine();

        }   

    }

}
