using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_BankAccount_abstract_class
{
    abstract class BankAccount
    {
        protected double balance;
        protected string accountNum;
        protected string ownerFirstName;
        protected string ownerLastName;

        public BankAccount()
        {
            balance = 1000.00;
            accountNum = "1234567890";
            ownerFirstName = "Unknown";
            ownerLastName = "Name";
        }
        public BankAccount(double bal, string num, string fn, string ln)
        {
            balance = bal;
            accountNum = num;
            ownerFirstName = fn;
            ownerLastName = ln;
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }
        public string OwnerFirstName
        {
            get { return ownerFirstName; }
            set { ownerFirstName = value; }
        }
        public string OwnerLastName
        {
            get { return ownerLastName; }
            set { ownerLastName = value; }
        }
        public abstract double Deposit(double x);
        ~BankAccount() { }
    }
}
