using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Practics
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape created");
        }
        public abstract void Draw();
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double ac;
        private readonly double bc;

        public Triangle(double ab,double bc,double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Console.WriteLine("Triangle created.");
        }
        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimeter()
        {
            return ab + ac + bc;
        }
    }
    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine("Rectangle created.");
        }

        public override double Area()
        {
            return width * height;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}
