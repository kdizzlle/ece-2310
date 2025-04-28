using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_grocerylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk();
            Bread bread = new Bread();
            Eggs eggs = new Eggs();
            Grocery list = new Grocery();

            double milk_cost = milk.total_price();
            double bread_cost = bread.total_price();
            double eggs_cost = eggs.total_price();

            Console.WriteLine("The current grocery list is: \n" + list.ToString());
            Console.WriteLine("\nWould you like to change the quantity of the items?\n" +
                "1 = yes\t\t2 = no\n");

            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice ==1)
            { 
                Console.WriteLine("How many jugs of milk do you want?");
                int milk_qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many loaves of bread do you want?");
                int bread_qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many cartons of eggs do you want?");
                int eggs_qty = Convert.ToInt32(Console.ReadLine());

                milk = new Milk(milk_qty);
                bread = new Bread(bread_qty);
                eggs = new Eggs(eggs_qty);

                //need to update these values now
                milk_cost = milk.total_price();
                bread_cost = bread.total_price();
                eggs_cost = eggs.total_price();

                Console.WriteLine("Here is the updated grocery list:\n" + list.ToString());
                Console.WriteLine("The total expense is $" + list.expense(milk_cost, bread_cost, eggs_cost));
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose not to change the grocery list.\n" +
                    "The total expense is $" + list.expense(milk_cost, bread_cost, eggs_cost));
            }
            else
            {
                Console.WriteLine("Invalid Entry. Start Over.");
            }

            Console.Read();
        }
    }
}
