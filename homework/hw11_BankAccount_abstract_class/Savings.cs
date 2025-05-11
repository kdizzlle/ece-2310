using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_BankAccount_abstract_class
{
    internal class Savings:BankAccount
    {
        private double interestRate;

        public Savings():base()
        {
            interestRate = 0.05;
        }
        public Savings(double interest, double b, string num, string fn, string ln):base(b, num, fn, ln)
        {
            interestRate = interest;
        }
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        public override double Deposit(double x)
        {
            Balance += x;
            Console.WriteLine("{0}'s new checking account balance after the {1} deposit is: ${2}", ownerFirstName, x, Balance);
            return Balance;
        }
        public override string ToString()
        {
            string outStr = "Account Type: Savings\nOwner Name: " + ownerFirstName + " " + ownerLastName +
                "\nAccount Number: " + accountNum + "\nInterest Rate: " + interestRate + "\nBalance: $" + balance;
            return outStr;
        }
        ~Savings() { }
    }
}
