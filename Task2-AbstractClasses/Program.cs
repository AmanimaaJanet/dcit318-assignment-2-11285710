using System;

namespace AbstractClassesAndMethods
{
    // Abstract base class
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double GetArea();
        
        // Non-abstract method that can be used by derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Area: {GetArea():F2} square units");
        }
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Property for radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Implementation of abstract method GetArea()
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Override DisplayInfo to include circle-specific information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius}:");
            base.DisplayInfo();
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        // Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Properties
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Implementation of abstract method GetArea()
        public override double GetArea()
        {
            return width * height;
        }

        // Override DisplayInfo to include rectangle-specific information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with width {width} and height {height}:");
            base.DisplayInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===\n");

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas using the implemented GetArea() method
            Console.WriteLine("Shape Areas:");
            circle.DisplayInfo();
            Console.WriteLine();
            rectangle.DisplayInfo();

            Console.WriteLine("\n--- Direct Area Calculations ---");
            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");

            // Demonstrate polymorphism with abstract classes
            Console.WriteLine("\n--- Polymorphism with Abstract Classes ---");
            Shape[] shapes = { new Circle(3.0), new Rectangle(2.0, 8.0), new Circle(7.5) };
            
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Shape {i + 1} area: {shapes[i].GetArea():F2}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}