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
            try
            {
                newCar.SetPrice(15000M);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prijs niet aanvaard: \n" + ex.Message);
            }

            Car secondCar;
            secondCar = new Car();

            secondCar.SetColor("turquoise");
            secondCar.SetBrand("Ford");
            try
            {
                secondCar.SetPrice(9000M);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prijs niet aanvaard: \n" + ex.Message);
            }

            Console.WriteLine($"De nieuwe auto is een {newCar.GetBrand()}, " +
                $"is {newCar.GetColor()} van kleur en kost {newCar.GetPrice()} incl. BTW");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {secondCar.GetBrand()}, " +
                $"is {secondCar.GetColor()} van kleur en kost {secondCar.GetPrice()} incl. BTW");
            Console.WriteLine("============");
            Console.WriteLine(newCar.GetAllInfo());


            Console.ReadLine();
        }
    }
}
