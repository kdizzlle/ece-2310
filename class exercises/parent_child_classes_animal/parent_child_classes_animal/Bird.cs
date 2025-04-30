using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace parent_child_classes_animal
{
    internal class Bird
    {
        private string color;

        public Bird():base()
        {
            color = "green";
        }
        public Bird(int a, string c):base(a)
        {
            color = c;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void Chirp()
        {
            Console.WriteLine("The {0} colored bird is chirping.",color);
        }
        public override void Move()
        {
            Console.WriteLine("The {0} colored bird is flying in the yard.", color);
        }
        public override string ToString()
        {
            return "A " + Age + "-year old " + color + " bird.";
        }
        ~Bird() { }
    }
}
