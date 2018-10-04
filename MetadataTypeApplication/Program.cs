using System;
using Application;
using Model;

namespace MetadataTypeConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var myShop = new Shop();
            var myCar = new Car {Color = "Red", Persons = 5, Price = (decimal) 25.3};
            var myMoto = new Moto {Color = "Black", Persons = 2, Price = (decimal) 15.8};
            var myCycle = new Cycle {Color = "Pink", Persons = 1, Price = (decimal) 3.2};
            var vehiculos = new object[] {myCar, myMoto, myCycle};

            foreach (object vehiculo in vehiculos)
            {
                myShop.PrintProperties(vehiculo);
                Console.WriteLine("...................................");
            }
            Console.ReadKey();
        }
    }
}

