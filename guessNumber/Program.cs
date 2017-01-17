using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter a number");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You guessed:" + input);

            if (input < 10)
            {
                Console.WriteLine("The number is too small");
            }
            else if (input >10)
            {
                Console.WriteLine("The number is big enough");
            }
            else Console.WriteLine("The number is 10");

        }
    }
}
