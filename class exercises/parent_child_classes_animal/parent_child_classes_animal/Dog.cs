using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parent_child_classes_animal
{
    internal class Dog:Animal //inheritance
    {
        private string breed;

        public Dog():base() //default constructor
        { //go to the base class and run the default constructor before running this:
            breed = "unknown";
        }

        public Dog(int a, string b):base(a) //inheritance overloaded constructor
        { //go to base class and run constructor that takes one input and use a
            breed = b;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public void Bark()
        {
            Console.WriteLine("The {0}-year old {1} dog is barking.",age, breed);
        }

        public override string ToString()
        {
            return "A "+age+"-year old "+breed+" dog.";
        }

        public override void Move()
        {
            Console.WriteLine("The {0}-year old {1} dog is running quickly in the park.", age, breed);
        }

        ~Dog() { }
    }
}
