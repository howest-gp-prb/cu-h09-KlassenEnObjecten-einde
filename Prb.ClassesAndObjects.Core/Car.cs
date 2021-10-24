using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public class Car
    {
        //private static int carCount;

        //public static int GetCarCount()
        //{
        //    return carCount;
        //}

        //In onderstaande region staan onze fields en get-en set-methoden
        #region Fields, get- en set-methoden
        #endregion

        private string color;
        private decimal price;

        public string Brand { get; set; }

        public string Color
        {
            get { return color; }
            set 
            { 
            string[] availableColors = { "wit", "rood", "zwart" };
            if (availableColors.Contains(value)) color = value;
            else color = "wit";                
            }
        }

        public decimal Price
        {
            get { return price; }
            set 
            {
                if (value < 15000M || price > 30000M)
                    throw new Exception("Geef een prijs tussen de 15 000 en 30 000 euro");
                else price = value;
            }
        }

        public string GetAllInfo
        {
            get
            {
            string info = $"Merk: {Brand}\nKleur: {color}\n";
            if (Price < 25000) info += $"Prijs excl. BTW: {Price}\nPrijs incl. BTW: {Price * 0.21M}";
            else info += "Contacteer je dealer voor meer prijsinfo";
            return info;
            }
        }

        public Car()  // dit is het equivalent van de default constructor
        {
            Brand = null;
            Color = null;
            Price = 15000M;
        }

        public Car(string brand) : this() // Constructor ontvangt 1 parameter
        {
            Brand = brand;
        }

        public Car(string brand, string color) : this(brand) // Constructor ontvangt 2 parameters
        {
            Color = color;
        }

        public Car(string brand, string color, decimal price) : this(brand, color) // Constructor ontvangt 3 parameters
        {
            Price = price;
        }
    }
}
