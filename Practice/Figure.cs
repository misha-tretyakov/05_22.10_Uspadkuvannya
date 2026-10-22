namespace Practice
{
    internal class Figure
    {
        public virtual double GetArea()
        {
            return 0;
        }

        public void PrintArea()
        {
            Console.WriteLine($"Area is {GetArea()}");
        }
    }


    internal class Rectangle : Figure
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _width * _height;
        }
    }


    internal class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }


    internal class RightTriangle : Figure
    {
        private double _firstLeg;
        private double _secondLeg;

        public RightTriangle(double firstLeg, double secondLeg)
        {
            _firstLeg = firstLeg;
            _secondLeg = secondLeg;
        }

        public override double GetArea()
        {
            return _firstLeg * _secondLeg / 2;
        }
    }


    internal class Trapezoid : Figure
    {
        private double _firstBase;
        private double _secondBase;
        private double _height;

        public Trapezoid(double firstBase, double secondBase, double height)
        {
            _firstBase = firstBase;
            _secondBase = secondBase;
            _height = height;
        }

        public override double GetArea()
        {
            return (_firstBase + _secondBase) * _height / 2;
        }
    }
}