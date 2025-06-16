using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parent_child_classes_animal
{
    //internal class Animal
    abstract class Animal
    {
        protected int age;
        public Animal()
        {
            age = 3;
        }
        public Animal(int a)
        {
            age = a;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    age = 0;
            }
        }
        //public abstract void Move();
        //public virtual void Move()
        //{
        //    Console.WriteLine("The {0}-year old animal  is moving slowly.", age);
        //}
        public override string ToString()
        {
            return "An animal at the age of "+age;
        }

        ~Animal() { }
    }
}
