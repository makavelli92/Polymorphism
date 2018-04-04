using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   abstract class Figure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public abstract double Area();

    }

    class Triangle : Figure
    {
        public Triangle(double x, double y) : base(x, y)
        {
        }

        public override double Area()
        {
            return X * Y / 2;
        }
    }

    class Pr : Figure
    {
        public string Name { get; set; }

        public Pr(double x, double y, string n) : base(x, y)
        {
            Name = n;
        }

        public override double Area()
        {
            return X * Y;
        }
    }
    class Program
    {
        static void M(Figure f)
        {
            Console.WriteLine(f.Area());
        }

        static void Main(string[] args)
        {
            M(new Pr(8, 4, "r"));
            M(new Triangle(9, 7));

            Console.ReadLine();

        }
    }
}