using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public static List<Car> Cars { get; set; } = new List<Car>();

        public Car ()
        {
            Make = "Ford";
            Model = "Fiesta";
            Year = 2010;
            Price = 11000;
        }
        public Car(string make, string model, int year, decimal price)
        {
            Make = make; 
            Model = model; 
            Year = year; 
            Price = price;
            
        }
        public override string ToString()
        {
            return $"{Make}, {Model}, {Year}, {Price}";
        }

        public static void ListCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i}, {Cars[i]}");
            }
        }

        public static void Remove(int carToRemove)
        {
            Cars.RemoveAt(carToRemove);
        }
                
    }

    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            Mileage = mileage;
        }
        public override string ToString()
        {
            return $"{Make}, {Model}, {Year}, {Price}, {Mileage}";
        }
    }
}
