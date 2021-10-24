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

        newCar.Color = "zwart";
        newCar.Brand = "Hyundai";
        newCar.Price = 15000M;

        Car secondCar;
        secondCar = new Car();

        secondCar.Color = "turquoise";
        secondCar.Brand = "Ford";
        secondCar.Price = 19000M;

        Car thirdCar = new Car("Audi", "blauw", 25000M);
            //decimal costDifference = newCar.PriceDifference(thirdCar);
            decimal costDifference = Car.PriceDifference(newCar, thirdCar);

            Console.WriteLine($"De nieuwe auto is een {newCar.Brand}, " +
            $"is {newCar.Color} van kleur en kost {newCar.Price} incl. BTW");
        Console.WriteLine("============");
        Console.WriteLine($"De tweede auto is een {secondCar.Brand}, " +
            $"is {secondCar.Color} van kleur en kost {secondCar.Price} incl. BTW");
        Console.WriteLine("============");
        Console.WriteLine(newCar.GetAllInfo);

        Console.WriteLine("============");
        Console.WriteLine($"De derde auto is een {thirdCar.Brand}, " +
            $"is {thirdCar.Color} van kleur en kost {thirdCar.Price}");
        Console.WriteLine("============");
        Console.WriteLine($"We hebben nu {Car.CarCount} auto's");

        Console.WriteLine("============");
        Console.WriteLine($"Prijsverschil tussen {newCar.Price} en {thirdCar.Price} is {costDifference}");


        Console.ReadLine();
    }
}
}
