using System;

namespace Shapes
{
    abstract class Polygon
    {
        protected uint sides { get; }
        public abstract float area();
        public abstract float perimeter();
        public override string ToString() => "Area: " + area() + ", Perimeter: " + perimeter();
        

        public Polygon(uint s) => sides = s;
    }

    class Square: Polygon
    {
        private uint sideLength;
        public Square(uint l) : base(4) => sideLength = l;
        public override float area()
        {
            return sideLength * sideLength;
        }
        public override float perimeter()
        {
            return base.sides * sideLength;
        }
    }

    class Rectangle : Polygon
    {
        private uint height;
        private uint width;
        public Rectangle(uint w, uint h) : base(4)
        {
            width = w;
            height = h;
        }

        public override float area()
        {
            return this.width * this.height;
        }
        public override float perimeter()
        {
            return ((base.sides) / 2 * width) + ((base.sides) / 2 * width);
        }
    }

    abstract class Triangle : Polygon
    {
       public Triangle() : base(3) { }
    }

    class Right : Triangle
    {
        private uint hypotenuse;
        private uint shortSide;
        private uint longSide;

        public Right(uint s, uint l, uint h)
        {
            shortSide = s;
            longSide = l;
            hypotenuse = h;
        }
        public override float area()
        {
            return 0.5f * shortSide * longSide;
        }
        public override float perimeter()
        {
            return shortSide + longSide + hypotenuse;
        }
    }

    class Equilateral : Triangle
    {
        private uint length;
        public Equilateral(uint l) => length = l;
        public override float area()
        {
            float floor = length / 2f;
            float height = floor * (float)Math.Sqrt(3);
            return 0.5f * floor * height;
        }
        public override float perimeter()
        {
            return base.sides * length;
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            Console.WriteLine($"{square}");
            Rectangle rectangle = new Rectangle(3, 6);
            Console.WriteLine($"{rectangle}");
            Equilateral eqTri = new Equilateral(4);
            Console.WriteLine($"{eqTri}");
            Right rTri = new Right(3, 4, 5);
            Console.WriteLine($"{rTri}");
        }
    }
}
