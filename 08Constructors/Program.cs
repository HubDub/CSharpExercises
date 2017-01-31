using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello car enthusiast!");
            Car car = new Car("Betsy");
            car.Start(); 
            Console.WriteLine("My car's name is " + car.GetName());
        }
    }
}
