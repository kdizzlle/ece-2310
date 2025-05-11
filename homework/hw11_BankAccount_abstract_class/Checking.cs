using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_BankAccount_abstract_class
{
    internal class Checking:BankAccount
    {
        private string bank;
        public Checking() : base()
        {
            bank = "Bank";
        }
        public Checking(string place, double b, string num, string fn, string ln) : base(b, num, fn, ln)
        {
            bank = place;
        }
        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }
        public override double Deposit(double x)
        {
            Balance += x;
            Console.WriteLine("{0}'s new checking account balance after the {1} deposit is: ${2}",ownerFirstName,x,Balance);
            return Balance;
        }
        public double Withdraw(double x)
        {
            Balance -= x;
            Console.WriteLine("{0} new checking account balance after the {1} withdraw is: ${2}",ownerFirstName,x,Balance);
            return Balance;
        }
        public override string ToString()
        {
            string outStr = "Account Type: Checking\nBank: " + bank + "Owner Name: " + ownerFirstName + " " + ownerLastName +
                "\nAccount Number: " + accountNum + "\nBalance: $" + balance;
            return outStr;
        }
        ~Checking() { }
    }
}
