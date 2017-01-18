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
            //using for loop to iterate through array
            for(int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            // using foreach to iterate through array
            foreach(double num in newArray)
            {
                Console.WriteLine(num);
            }    
        }
    }
}
