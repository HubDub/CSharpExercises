using System;

namespace ConsoleApplication
{
    public class Car
    {
        private string name; 
        
        public Car(string name) 
        {
            this.name = name;
        }

        public void Start() {
            Console.WriteLine("Car Started");
        }

        public string GetName() {
            return name;
        }

    }
}