using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Magazine:ReadingMaterial
    {
        private string editor;

        public Magazine()
        {
            editor = "Editor-In-Chief";
        }
        public Magazine(string e, string t, double p)
        {
            editor = e;
            Title = t;
            Price = p;
        }
        public string Editor
        {
            get { return editor; }
            set { editor = value; }
        }
        public void Subscribe(bool s)
        {
            if (s)
                Console.WriteLine("You are subscribed to " + Title + " magazine.");
            else
                Console.WriteLine("You are not subscribed to " + Title + " magazine.");
        }
        public override string ToString()
        {
            return "Magazine Title: " + Title + "  |  Editor-in-chief: " + editor + "  |  Price: $" + Price;
        }
    }
}
