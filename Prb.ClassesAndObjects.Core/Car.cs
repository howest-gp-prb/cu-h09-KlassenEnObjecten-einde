using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public class Car
    {
        private static int carCount;

        public static int GetCarCount()
        {
            return carCount;
        }

        //In onderstaande region staan onze fields en get-en set-methoden
        #region Fields, get- en set-methoden
        private string brand;
        private string color;
        private decimal price;



        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string newBrand)
        {
            brand = newBrand;
        }

        public string GetColor()
        {
            string fullColorName = color;
            if (color == "rood")
                fullColorName = "Ferrari-rood";
            return fullColorName;
        }

        public void SetColor(string newColor)
        {
            string[] availableColors = { "wit", "rood", "zwart" };
            if (availableColors.Contains(newColor))
                color = newColor;
            else
                color = "wit";
        }

        public decimal GetPrice()
        {
            return price * 1.21M;
        }

        public void SetPrice(decimal price)
        {
            if (price < 15000M || price > 30000M)
                throw new Exception("Geef een prijs tussen de 15 000 en 30 000 euro");
            else
                this.price = price;
        }

        public string GetAllInfo()
        {
            string info = $"Merk: {brand}\nKleur: {color}\n";
            if (price < 25000)
                info += $"Prijs excl. BTW: {price}\nPrijs incl. BTW: {GetPrice()}";
            else
                info += "Contacteer je dealer voor meer prijsinfo";
            return info;
        }
        #endregion

        public Car()  // dit is het equivalent van de default constructor
        {
            brand = null;
            color = null;
            price = 0;
            carCount++;
        }

        public Car(string brand) : this() // Constructor ontvangt 1 parameter
        {
            this.brand = brand;
        }

        public Car(string brand, string color) : this() // Constructor ontvangt 2 parameters
        {
            this.brand = brand;
            SetColor(color);
        }

        public Car(string brand, string color, decimal price) : this() // Constructor ontvangt 3 parameters
        {
            this.brand = brand;
            SetColor(color);
            SetPrice(price);
        }
    }
}
