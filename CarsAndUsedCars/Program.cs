namespace CarsAndUsedCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProgram();

        }
        static void RunProgram ()
        {
            Car car = new Car ();

            Console.WriteLine (car.ToString());
        }
    }
}