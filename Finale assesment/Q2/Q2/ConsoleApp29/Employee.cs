using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Employee
    {
        //public variables
        public string name;
        public double annualGross;
        public double taxRate;



        //constuctor
        public Employee()
        {
            Console.WriteLine("Employee record created");
        }


        //method to calculate salary
        public double CalcNet()
        {
            double netSalary = annualGross - (taxRate/100) * annualGross;
            return netSalary;
        }

    }

}
