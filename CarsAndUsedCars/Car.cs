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
        public List<Car> Cars { get; set; }

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
                
    }
}
