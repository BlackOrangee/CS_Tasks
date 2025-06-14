// Create a base class called Vehicle,
// which has properties for the brand and year of manufacture of the vehicle.
// Create derived classes: Car and Motorcycle.
// Each of these classes should have its unique properties and methods.
// Create several objects of both classes and display information about them.
//

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.setYear(1999);
            car.setBrand("Toyota");

            Console.WriteLine($"Year: {car.getYear()} Brand: {car.getBrand()} Move: {car.Move()} Stop: {car.Stop()}");

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.setYear(2001);
            motorcycle.setBrand("Honda");

            Console.WriteLine($"Year: {motorcycle.getYear()} Brand: {motorcycle.getBrand()} Move: {motorcycle.Move()} Stop: {motorcycle.Stop()}");
        }
    }
}