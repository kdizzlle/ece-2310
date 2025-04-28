using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hw10_grocerylist
{
    internal class Grocery
    {
        // data members from composition
        private Milk my_milk;
        private Bread my_bread;
        private Eggs my_eggs;

        //constructors
        public Grocery() //default constructor
        {
            my_milk = new Milk();
            my_bread = new Bread();
            my_eggs = new Eggs();
        }
        public Grocery(int qm,int qb,int qe) //overloaded constructor
        {
            my_milk = new Milk(qm);
            my_bread = new Bread(qb);
            my_eggs = new Eggs(qe);
        }

        //methods
        public double expense(double m, double b, double e)
        {
            return Math.Round(m + b + e, 2);
        }
        public override string ToString()
        {
            string outstr =  "\nItem\tUnit Price\tQuantity\n";
            outstr += my_milk.ToString();
            outstr += my_bread.ToString();
            outstr += my_eggs.ToString();
            return outstr;
        }
    }
}
