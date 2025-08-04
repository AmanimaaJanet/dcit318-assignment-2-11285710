using System;

namespace InterfacesDemo
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Additional interface to demonstrate multiple interface implementation
    public interface IStartable
    {
        void Start();
        void Stop();
    }

    // Car class implementing IMovable
    public class Car : IMovable, IStartable
    {
        private string brand;
        private bool isRunning;

        // Constructor
        public Car(string brand)
        {
            this.brand = brand;
            this.isRunning = false;
        }

        // Property
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Implementation of IMovable interface
        public void Move()
        {
            if (isRunning)
            {
                Console.WriteLine($"{brand} car is moving");
            }
            else
            {
                Console.WriteLine($"{brand} car cannot move - engine is not running");
            }
        }

        // Implementation of IStartable interface
        public void Start()
        {
            isRunning = true;
            Console.WriteLine($"{brand} car engine started");
        }

        public void Stop()
        {
            isRunning = false;
            Console.WriteLine($"{brand} car engine stopped");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        private string type;
        private int gears;

        // Constructor
        public Bicycle(string type, int gears)
        {
            this.type = type;
            this.gears = gears;
        }

        // Properties
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Gears
        {
            get { return gears; }
            set { gears = value; }
        }

        // Implementation of IMovable interface
        public void Move()
        {
            Console.WriteLine($"{type} bicycle is moving");
        }

        // Additional method specific to Bicycle
        public void RingBell()
        {
            Console.WriteLine("Ring ring! Bicycle bell");
        }
    }

    // Additional class to demonstrate interface usage
    public class Skateboard : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Skateboard is rolling");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===\n");

            // Create instances of Car and Bicycle
            Car car = new Car("Toyota");
            Bicycle bicycle = new Bicycle("Mountain", 21);

            // Call the Move() method on each instance
            Console.WriteLine("--- Direct Method Calls ---");

            // Car needs to be started first
            car.Start();
            car.Move();
            car.Stop();
            car.Move(); // Try to move when stopped

            Console.WriteLine();
            bicycle.Move();
            bicycle.RingBell(); // Bicycle-specific method

            // Demonstrate polymorphism with interfaces
            Console.WriteLine("\n--- Polymorphism with Interfaces ---");
            IMovable[] movableObjects = {
                new Car("Honda"),
                new Bicycle("Road", 18),
                new Skateboard()
            };

            foreach (IMovable obj in movableObjects)
            {
                obj.Move();
            }

            // Demonstrate multiple interface implementation
            Console.WriteLine("\n--- Multiple Interface Implementation ---");
            Car sportsCar = new Car("Ferrari");

            // Using as IMovable
            IMovable movableVehicle = sportsCar;
            movableVehicle.Move();

            // Using as IStartable
            IStartable startableVehicle = sportsCar;
            startableVehicle.Start();
            movableVehicle.Move(); // Now it can move

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}