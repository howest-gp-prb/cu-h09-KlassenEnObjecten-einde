using System;
using Prb.ClassesAndObjects.Core;

namespace Prb.ClassesAndObjects.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar;
            newCar = new Car();

            newCar.color = "zwart";
            newCar.brand = "Hyundai";
            newCar.price = 15000M;

            Car secondCar;
            secondCar = new Car();

            secondCar.color = "wit";
            secondCar.brand = "Ford";
            secondCar.price = 9000M;

            Console.WriteLine($"De nieuwe auto is een {newCar.brand}, is {newCar.color} van kleur en kost {newCar.price}");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {secondCar.brand}, is {secondCar.color} van kleur en kost {secondCar.price}");

            Console.ReadLine();

        }
    }
}
