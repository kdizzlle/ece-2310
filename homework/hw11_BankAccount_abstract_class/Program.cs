using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_BankAccount_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Testing Checking Class-----");
            Checking[] check = new Checking[2];
            check[0] = new Checking();
            check[1] = new Checking("Wells Fargo", 500.00, "707717930", "Amy", "Smith");
            Console.WriteLine("Instantiated Objects:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("check[{0}]: {1}", i, check[i]);
            }
            check[0].Bank = "Chase";
            check[0].Balance = 200.00;
            check[0].AccountNum = "909338981";
            check[0].OwnerFirstName = "Lisa";
            check[0].OwnerLastName = "Cohen";
            Console.WriteLine("Updated check[0]: " + check[0]);
            double x = check[1].Deposit(60.99);
            double y = check[0].Withdraw(42.50);

            Console.WriteLine("\n-----Testing Savings Class-----");
            Savings[] save = new Savings[2];
            save[0] = new Savings();
            save[1] = new Savings(0.63, 5000.00, "707717930", "Amy", "Smith");
            Console.WriteLine("Instantiated Objects:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("save[{0}]: {1}", i, save[i]);
            }
            save[0].InterestRate = 0.52;
            save[0].Balance = 200.00;
            save[0].AccountNum = "909338981";
            save[0].OwnerFirstName = "Lisa";
            save[0].OwnerLastName = "Cohen";
            Console.WriteLine("Updated save[0]: " + save[0]);
            double z = save[1].Deposit(60.99);

            Console.Read();
        }
    }
}
