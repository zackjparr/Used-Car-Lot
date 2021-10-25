using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar : Car
    {
        public double Mileage { get; set; } = 0;
        public UsedCar(string Make, string Model, int Year, double Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            return $"{Year} - {Make} {Model}: ${Price.ToString("0.00")} || Used at {Mileage} miles";
        }
    }
}
