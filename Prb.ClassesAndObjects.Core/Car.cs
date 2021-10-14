using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public class Car
    {
        private string brand;
        private string color;
        private decimal price;

        public void SetBrand(string newBrand)
        {
            brand = newBrand;
        }

        public void SetColor(string newColor)
        {
            string[] availableColors = { "wit", "rood", "zwart" };
            if (availableColors.Contains(newColor))
                color = newColor;
            else
                color = "Wit";
        }

        public void SetPrice(decimal price)
        {
            if (price < 15000M || price > 30000M)
                throw new Exception("Geef een prijs tussen de 15 000 en 30 000 euro");
            else
                this.price = price;
        }
    }
}
