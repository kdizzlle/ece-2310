using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Book:ReadingMaterial
    {
        private string author;
        private Date publishDate;

        public Book()
        {
            author = "Author Name";
            publishDate = new Date();
        }
        public Book(string a, Date d, string t, double p)
        {
            author = a;
            publishDate = d;
            Title = t;
            Price = p;
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Date PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        public void Donate(bool d)
        {
            if (d)
                Console.WriteLine("You would like to donate "+Title+".");
            else
                Console.WriteLine("You would like to keep "+Title+".");
        }
        public override string ToString()
        {
            return "Book Title: " + Title + "   |   Author: " + author + 
                "   |   Published: " + publishDate.DisplayDate() + "   |   Price: $" + Price;
        }
    }
}
