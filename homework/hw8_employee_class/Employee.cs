using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_employee_class
{
    class Employee
    {
        //data members
        private string empNum;
        private string firstName;
        private string lastName;
        private double salary;

        //methods
        public Employee() //default constructor
        {
            empNum = "123456789";
            firstName = "John";
            lastName = "Doe";
            salary = 2000;
        }
        public Employee(string enb, string fn, string ln, double sal) //overloaded constructor
        {//if you know all info
            empNum = enb;
            firstName = fn;
            lastName = ln;
            salary = sal;
        }
        public Employee(string enb, double sal) //overloaded constructor
        {//if all you know is employee number and salary
            firstName = "First";
            lastName = "Last";
            empNum = enb;
            salary = sal;
        }
        public double AnnualPay()
        {
            return Math.Round((salary * 12),2);
        }
        public void DisplayInfo(double annual)
        {
            Console.WriteLine("{0} {1}\nEmployee ID: {2}\n${3} monthly salary\n${4} annual salary\n",
                firstName, lastName, empNum, salary, annual);
        }
    }
}
