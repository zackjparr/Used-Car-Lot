using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Dealership
    {
        List<Car> Cars { get; set; } = new List<Car>();

        public Dealership()
        {
            Cars.Add(new NewCar("Honda", "Civic", 2021, 21250.00));
            Cars.Add(new NewCar("Tesla", "Model S", 2021, 69420.00));
            Cars.Add(new NewCar("Audi", "A8", 2021, 86500.99));
            Cars.Add(new UsedCar("Pontiac", "Aztek", 2005, 4200.99, 100000));
            Cars.Add(new UsedCar("Kia", "Soul", 2009, 2300.02, 120000));
            Cars.Add(new UsedCar("Cursed", "Sedan", 666, 666, 666));
        }

        public void PrintCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine(Cars[i]);
                Console.WriteLine();
            }
        }

        public void Checkout()
        {
            bool goOn = true;
            PrintCars();
            Console.WriteLine();
            Console.WriteLine("Would you like to ADD or PURCHASE a vehicle?");
            string answer = Console.ReadLine().ToLower();

            while (goOn == true)
            {
                if (answer == "add")
                {
                    AddCar();
                }
                else if (answer == "purchase")
                {
                    PurchaseCar();
                }
                else
                {
                    Console.WriteLine("Please enter either ADD or PURCHASE please. We are trying to run a business here.");
                    Checkout();
                }
                goOn = Continue();
            }
        }

        public void AddCar()
        {
            Console.WriteLine("Please enter the info of the car you would like to add.");
            Console.WriteLine("Enter the car's make:");
            string make = Console.ReadLine();
            Console.WriteLine("Enter the car's model:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the car's year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the car's price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Is the car USED or NEW?");
            string cond = Console.ReadLine().ToLower();

            if (cond == "used")
            {
                Console.WriteLine("How many miles does it have?");
                double miles = double.Parse(Console.ReadLine());
                Cars.Add(new UsedCar(make, model, year, price, miles));
                Console.WriteLine($"{year} {make} {model} has been added to our inventory");
            }
            else if (cond == "new")
            {
                Cars.Add(new NewCar(make, model, year, price));
                Console.WriteLine($"{year} {make} {model} has been added to our inventory");
            }
            else
            {
                Console.WriteLine("I'm tryin' to run a business here! CMON!!! NEW or USED?!");
                AddCar();
            }
            
        }

        public void PurchaseCar()
        {
            Console.WriteLine("What is the model of the vehicle you would like to purchase?");
            string model = Console.ReadLine().ToLower();
            Cars.RemoveAll(Car => Car.Model.ToLower() == model);
            Console.WriteLine($"Congratulations on purchasing the {model} car!");
        }

        public bool Continue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Checkout();
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't understand, please try again. Enter only y/n.");
                return false;
            }

        }
    }
}
