namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2016;

            Console.WriteLine($"My car is a {car1.Year} {car1.Make} {car1.Model}.");
        }
    }
}
