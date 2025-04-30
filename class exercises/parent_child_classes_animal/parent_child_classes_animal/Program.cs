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


            Console.Read();
        }
    }
}
