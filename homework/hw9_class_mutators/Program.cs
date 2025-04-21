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

            Console.WriteLine("Please enter the information for the employee:");
            Console.WriteLine("First name: ");
            emp01.FirstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            emp01.LastName = Console.ReadLine();
            Console.WriteLine("Employee Number: ");
            emp01.EmpNum = Console.ReadLine();
            Console.WriteLine("Total Sales this month: ");
            emp01.TotalSales = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDisplaying employee info...\n");
            emp01.DisplayInfo(emp01.AnnualPay());

            Console.Read();
        }
    }
}