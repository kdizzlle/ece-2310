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
        private double sales;

        //methods
        public Employee() //default constructor
        {
            empNum = "123456789";
            firstName = "John";
            lastName = "Doe";
            sales = 2000;
        }
        public Employee(string enb, string fn, string ln, double sal) //overloaded constructor
        {//if you know all info
            empNum = enb;
            firstName = fn;
            lastName = ln;
            sales = sal;
        }
        public Employee(string enb, double sal) //overloaded constructor
        {//if all you know is employee number and salary
            firstName = "First";
            lastName = "Last";
            empNum = enb;
            sales = sal;
        }
        public double AnnualPay()
        {
            double pay=0;
            pay = (sales * 0.09);
            pay -= (pay * 0.18 + pay * 0.10 + pay * 0.06); //monthly
            pay *= 12; //annual
            return Math.Round(pay, 2);
        }
        public void DisplayInfo(double annual)
        {
            Console.WriteLine("{0} {1}\nEmployee ID: {2}\n${3} monthly salary\n${4} annual salary\n",
                firstName, lastName, empNum, salary, annual);
        }
        //mutators
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double TotalSales
        {
            get { return sales; }
            set { sales = value; }
        }
    }
}