using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Testing ReadingMaterial Base Class-----");
            ReadingMaterial[] rm = new ReadingMaterial[2];
            rm[0] = new ReadingMaterial();
            rm[1] = new ReadingMaterial("Lord of the Rings", 12.99);
            rm[0].Read(false);
            rm[1].Read(true);
            
            Console.WriteLine("\n-----Testing Book Class-----");
            Book[] mybook = new Book[2];
            Date[] mydate = new Date[2];
            mydate[0] = new Date();
            mydate[1] = new Date("05", "26", "1897");
            mybook[0] = new Book();
            mybook[1] = new Book("Bram Stoker", mydate[1], "Dracula", 5.99);
            mybook[0].Title = "C++ Programming";
            mybook[0].Author = "John Smith";
            mydate[0].Month = "01";
            mydate[0].Day = "09";
            mydate[0].Year = "2021";
            mybook[0].PublishDate = mydate[0];
            mybook[0].Price = 100.00;
            for (int i = 0; i < 2; i++)
                Console.WriteLine("mybook[{0}]: {1}", i, mybook[i]);
            mybook[1].PublishDate.Year = "2019";
            Console.WriteLine("mybook[0] updated year: " + mybook[0].PublishDate.Year);
            Console.WriteLine("mybook[0] updated date: "+mydate[0].DisplayDate());
            mybook[1].Donate(true);
            mybook[0].Donate(false);

            Console.WriteLine("\n-----Testing Magazine Class-----");
            Magazine[] hermag = new Magazine[2];
            hermag[0] = new Magazine();
            hermag[1] = new Magazine("Rory Gilmore", "Cool Girls Go to Yale", 15.00);
            hermag[0].Title = "Keto for Life";
            hermag[0].Editor = "Paula Wang";
            hermag[0].Price = 20.00;
            for (int i = 0; i < 2; i++)
                Console.WriteLine("hermag[{0}]: {1}", i, hermag[i]);
            hermag[0].Price = 18.80;
            Console.WriteLine(hermag[0].Title + " reduced price: $" + hermag[0].Price);


            Console.Read();
        }
    }
}
