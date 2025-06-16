using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class ReadingMaterial
    {
        private string title;
        private double price;

        public ReadingMaterial()
        {
            title = "Title";
            price = 9.99;
        }
        public ReadingMaterial(string t, double p)
        {
            title = t;
            price = p;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Read(bool r)
        {
            if (r)
                Console.WriteLine("This material has been read.");
            else
                Console.WriteLine("This material has not beed read");
        }

        public override string ToString()
        {
            return "Title: " + title + "   |   Price: $" + price + "\n";
        }

    }
}
