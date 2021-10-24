using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public class CarWithMethods
    {
        //In onderstaande region staan onze fields en get-en set-methoden
        #region Fields, get- en set-methoden
        #endregion



        private decimal price;

        private string brand;
        public void SetBrand(string newBrand)
        {
            brand = newBrand;
        }
        public string GetBrand()
        {
            return brand;
        }        
        
        private string color;
        public string GetColor()
        {
            return color;
        }

        public void SetColor(string newColor)
        {
            string[] availableColors = { "wit", "rood", "zwart" };
            if (availableColors.Contains(newColor)) color = newColor;
            else color = "wit";
        }



        public void SetPrice(decimal price)
        {
            if (price < 15000M || price > 30000M)
                throw new Exception("Geef een prijs tussen de 15 000 en 30 000 euro");
            else this.price = price;
        }
        public decimal GetPrice()
        {
            return price;
        }

        public string GetAllInfo()
        {
            string info = $"Merk: {GetBrand()}\nKleur: {GetColor()}\n";
            if (GetPrice() < 25000) info += $"Prijs excl. BTW: {GetPrice()}\nPrijs incl. BTW: {GetPrice() * 0.21M}";
            else info += "Contacteer je dealer voor meer prijsinfo";
            return info;
        }

        public CarWithMethods()  // dit is het equivalent van de default constructor
        {
            brand = null;
            color = null;
            price = 0;
        }

        public CarWithMethods(string brand) : this() // Constructor ontvangt 1 parameter
        {
            this.brand = brand;
        }

        public CarWithMethods(string brand, string color) : this(brand) // Constructor ontvangt 2 parameters
        {
            SetColor(color);
        }

        public CarWithMethods(string brand, string color, decimal price) : this(brand, color) // Constructor ontvangt 3 parameters
        {
            SetPrice(price);
        }

    }
}
