using System.Collections.Generic;
using System;
namespace SOLID_PRINCIPLES.LSP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Usage
            List<Shape> shapes = new List<Shape>
            {
                new Circle { Radius = 5 },
                new Square { SideLength = 4 }
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area of : {shape.Area()}");
            }
            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }
}