using System;

namespace InheritanceAndOverriding
{
    // Base class
    public class Animal
    {
        // Virtual method that can be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===");
            Console.WriteLine();

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() method on each instance
            Console.Write("Animal sound: ");
            animal.MakeSound();

            Console.Write("Dog sound: ");
            dog.MakeSound();

            Console.Write("Cat sound: ");
            cat.MakeSound();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}