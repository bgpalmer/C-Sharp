using System;

namespace Shapes
{
    abstract class Polygon
    {
        protected uint sides;
        public abstract float area();
        public abstract float perimeter();

        public Polygon(uint s)
        {
            sides = s;
        }
    }

    class Square: Polygon
    {
        private uint sideLength;
        public Square(uint l) : base(4)
        {
            sideLength = l;
        }
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
            height = h;
            width = w;
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
        public Equilateral(uint len)
        {
            length = len;
        }
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
            Console.WriteLine("Square: area = {0}, perimeter = {1}.", square.area(), square.perimeter());
            Rectangle rectangle = new Rectangle(3, 6);
            Console.WriteLine("Rectangle: area = {0}, perimeter = {1}.", rectangle.area(), rectangle.perimeter());
            Equilateral eqTri = new Equilateral(4);
            Console.WriteLine("EquilateralTriangle: Area = {0}, Perimeter = {1}.", eqTri.area(), eqTri.perimeter());
            Right rTri = new Right(3, 4, 5);
            Console.WriteLine("RightTriangle: Area = {0}, Perimeter = {1}.", rTri.area(), rTri.perimeter());
        }
    }
}