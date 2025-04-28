using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_grocerylist
{
    internal class Eggs
    {
        // data members
        private double unit_price;
        private int quantity;

        //constructors
        public Eggs() //default constructor
        {
            unit_price = 4.00;
            quantity = 3;
        }
        public Eggs(int x) //overloaded constructor
        {
            unit_price = 4.00;
            quantity = x;
        }

        //properties
        public double Unit_Price
        {
            get { return unit_price; }
            set { unit_price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //methods
        public double total_price()
        {
            return Math.Round(unit_price * quantity, 2);
        }
        public override string ToString()
        {
            return "\nEggs\t$" + unit_price + "\t\t" + quantity;
        }
    }
}
