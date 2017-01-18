using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // string[,] TwoDimArray = new string[2,3]; //this instantiates a new array
            string[,] TwoDimArray = {{"cat","bird","dog"}, {"horse","cow","tiger"}}; //this isantiates a new array and declares the values at the same time
            Console.WriteLine("one of the values in this two dimensional array is dog and this should say dog after the colon: " + TwoDimArray[0,2]);
        }
    }
}
