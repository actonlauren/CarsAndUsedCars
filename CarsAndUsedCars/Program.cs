namespace CarsAndUsedCars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car.Cars.Add(new Car("Tacoma", "Toyota", 2024, 20000));
            Car.Cars.Add(new Car("Odyssey", "Honda", 2024, 30000));
            Car.Cars.Add(new Car("Forester", "Subaru", 2024, 40000));

            Car.Cars.Add(new UsedCar("Contour", "Ford", 1991, 4000, 100000));
            Car.Cars.Add(new UsedCar("Prius", "Toyota", 2011, 11000, 70000));
            Car.Cars.Add(new UsedCar("Fiesta", "Ford", 2010, 10000, 60000));
            Car.Cars.Add(new UsedCar("Matrix", "Toyota", 2009,8900 ,65000));

            bool keepGoing = true;
            do
            {
                Car.ListCars();
                Console.WriteLine("Which car would you like to buy, by number?");
                string usersItems = Console.ReadLine().ToLower();
                int usersCarChoice = Convert.ToInt32(usersItems);
                if (usersCarChoice != null)
                {
                    Console.WriteLine($"{usersCarChoice} : {Car.Cars[usersCarChoice]}\n");
                    Car.Remove(usersCarChoice);
                    foreach (var carItem in Car.Cars)
                    {
                        Console.WriteLine(carItem);
                    }
                }
                else
                    Console.WriteLine("Unavailable item or Invalid response. Please try again.");


                Console.Write($"If that is your final car press, F. Otherwise press any key to continue.");
                string userContinue = Console.ReadLine();
                if (userContinue.ToLower() == "f")
                {
                    keepGoing = false;
                }

                else
                    Console.WriteLine("Okay, lets continue.");

            }
            while (keepGoing == true);

            Console.WriteLine("Thanks for using Car Shopper!");



        }
        
    }
}