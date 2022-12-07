using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Chevrolet";
            car1.Model = "Apache";
            car1.Year = 1959;

            Console.WriteLine($"The {car1.Year} {car1.Make} {car1.Model} is an iconic pickup truck! Put it on 36's and you're the talk of the town!");
        }
    }
}
