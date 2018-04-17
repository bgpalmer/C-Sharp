using System;

namespace ConsoleApp1
{
    class Vehicle
    {
        private string owner;
        private short wheels;
        private short doors;
        private uint year;
        protected string brand;

        public Vehicle(string o, short d, uint y)
        {
            owner = o;
            wheels = 4;
            doors = d;
            year = y;
        }
        public void stats()
        {
            Console.WriteLine("Owner: {0}, Brand: {1}, Wheels: {2}, Doors: {3}, Year: {4}", owner, brand, wheels, doors, year);
        }
    }

    class Honda: Vehicle
    {
        public Honda(string o, short d, uint y) : base(o, d, y)
        {
            this.brand = "Honda";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Honda myVehicle = new Honda("Me", 5, 2012);
            myVehicle.stats();

            return;
        }
    }
}
