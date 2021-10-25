using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string Make, string Model, int Year, double Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public virtual void PrintInfo(Car car)
        {
            Console.WriteLine("");
            string input = $"[Make] {car.Make}\n";
            input += $"[Model] {car.Model}\n";
            input += $"[Year] {car.Year}\n";
            Console.WriteLine(input);
        }

        public override string ToString()
        {
            return $"{Year} - {Make} {Model}: ${Price.ToString("0.00")}";
        }
    }
}
