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

            newCar.SetColor("zwart");
            newCar.SetBrand("Hyundai");
            newCar.SetPrice(15000M);


            Car secondCar;
            secondCar = new Car();

            secondCar.SetColor("turquoise");
            secondCar.SetBrand("Ford");
            secondCar.SetPrice(19000M);

            Car thirdCar = new Car("Audi", "blauw", 25000M);

            Console.WriteLine($"De nieuwe auto is een {newCar.GetBrand()}, " +
                $"is {newCar.GetColor()} van kleur en kost {newCar.GetPrice()} incl. BTW");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {secondCar.GetBrand()}, " +
                $"is {secondCar.GetColor()} van kleur en kost {secondCar.GetPrice()} incl. BTW");
            Console.WriteLine("============");
            Console.WriteLine(newCar.GetAllInfo());

            Console.WriteLine("============");
            Console.WriteLine($"De derde auto is een {thirdCar.GetBrand()}, " +
                $"is {thirdCar.GetColor()} van kleur en kost {thirdCar.GetPrice()}");

            Console.ReadLine();
        }
    }
}
