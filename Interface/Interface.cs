using System;

namespace InterfaceDemo
{
    // Define interface
    interface IMovable
    {
        void Move();
    }

    //  class: Car
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    //  class: Bicycle
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBike = new Bicycle();

            myCar.Move();     
            myBike.Move();    
        }
    }
}

