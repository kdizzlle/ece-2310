using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parent_child_classes_animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("-----Testing Animal Class-----");
            Animal[] anm = new Animal[2];
            anm[0] = new Animal();
            anm[1] = new Animal(12);
            Console.WriteLine("Here are the objects instantiated:");
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("anm[{0}]: {1}", i, anm[i]);
            }
            anm[0].Age = 1;
            for (int i = 0; i < 2; i++)
                anm[i].Move();

            Console.WriteLine("\n-----Testing Dog Class-----");
            Dog[] dogs = new Dog[2];
            dogs[0] = new Dog();
            dogs[1] = new Dog(7, "Schnauzer");
            for(int i=0; i<2; i++)
                Console.WriteLine("dogs[{0}]: {1}", i, dogs[i]);
            dogs[0].Breed = "Goldendoodle";
            dogs[0].Bark();
            dogs[1].Move();

            Console.WriteLine("\n-----Testing Bird Class-----");
            Bird[] birds = new Bird[2];
            birds[0] = new Bird();
            birds[1] = new Bird(1, "bright red");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("birds[{0}]: {1}", i, birds[i]);
            birds[0].Color = "Yellow";
            birds[0].Chirp();
            birds[1].Move();
            */
            Console.WriteLine("\n-----Static Binding-----");
            //instantiate one object of each class: Animal, Dog, Bird
            //Animal test1 = new Animal(7); //before Animal was abstract
            Dog test1 = new Dog();
            Dog test2 = new Dog(3, "husky");
            Bird test3 = new Bird(1, "blue");
            //display these 3 objects
            Console.WriteLine("test1: {0}", test1.ToString());
            Console.WriteLine("test2: {0}", test2.ToString());
            Console.WriteLine("test3: {0}", test3.ToString());
            //make these 3 objects move
            test1.Move();
            test2.Move();
            test3.Move();

            Console.WriteLine("\n-----Static Binding-----");
            //declare an array of 4 Animal objects
            Animal[] Test = new Animal[4];
            //these are 2 birds, 1 dog, and 1 animal
            Test[0] = new Bird(2, "yellow");
            Test[1] = new Bird(3, "green");
            Test[2] = new Dog(12, "German Shepherd");
            //Test[3] = new Animal(4); //before animal was abstract
            Test[3] = new Dog(4, "chiwawa"); //changed to dog - Animal is abstract now
            //display the 4 objects
            for (int i = 0; i < 4; i++)
                Console.WriteLine("Test[{0}]: {1}", i, Test[i].ToString());
            //make these 4 objects move
            for (int i = 0; i < 4; i++)
                Test[i].Move();

            Console.Read();
        }
    }
}
