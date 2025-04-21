using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_employee_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Annual Salary Calculator\n");
            Employee emp01 = new Employee();
            Employee emp02 = new Employee("326352489", "Harry", "Styles", 6000);
            Employee emp03 = new Employee("658423679", 5000);

            emp01.DisplayInfo(emp01.AnnualPay());
            emp02.DisplayInfo(emp02.AnnualPay());
            emp03.DisplayInfo(emp03.AnnualPay());

            Console.WriteLine("Please enter the information for Employee #1:");
            Console.WriteLine("First name: ");
            emp01.FirstName() = Console.ReadLine();

            Console.ReadLine();
        }
    }
}