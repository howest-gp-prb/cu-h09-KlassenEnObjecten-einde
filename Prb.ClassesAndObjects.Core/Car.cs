﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
public partial class Car
{
        //In onderstaande region staan onze fields en get-en set-methoden
        #region Reeds bestaande fields en properties
        private string color;
        private decimal price;
        private static int carCount;

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
        public static int CarCount
        {
            get { return carCount; }
            private set { carCount = value; }
        }

        public string GetAllInfo
        {
            get
            {
            string info = $"Merk: {Brand}\nKleur: {Color}\n";
            if (Price < 25000) info += $"Prijs excl. BTW: {Price}\nPrijs incl. BTW: {Price * 1.21M}";
            else info += "Contacteer je dealer voor meer prijsinfo";
            return info;
            }
        }
        #endregion

        public Car()  // dit is het equivalent van de default constructor
        {
            Brand = null;
            Color = null;
            Price = 15000M;
            CarCount++;
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
