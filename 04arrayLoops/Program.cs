using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Arrays and Loops");
            double[] newArray = {1.5, 2.5, 3.5, 4.5, 5.0};
            Console.WriteLine("These are the numbers in your array");
            foreach(double num in newArray)
            {
                Console.WriteLine(num);
            }    
        }
    }
}
