namespace RewardQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 5);
            Console.WriteLine("Area of " + circle.shapeName + ": " + circle.findArea());
            Console.WriteLine("Perimeter of " + circle.shapeName + ": " + circle.findPerimeter());

            Rectangle rectangle = new Rectangle("Rectangle", 10, 5);
            Console.WriteLine("Area of " + rectangle.shapeName + ": " + rectangle.findArea());
            Console.WriteLine("Perimeter of " + rectangle.shapeName + ": " + rectangle.findPerimeter());

            Console.ReadLine();
        }
        public abstract class Shape
        {
            public string shapeName;

            public Shape(string shapeName)
            {
                this.shapeName = shapeName;
            }

            public abstract double findArea();
            public abstract double findPerimeter();
        }

        public class Circle : Shape
        {
            private double radius;

            public Circle(string shapeName, double radius) : base(shapeName)
            {
                this.radius = radius;
            }

            public override double findArea()
            {
                return Math.PI * Math.Pow(radius, 2);
            }

            public override double findPerimeter()
            {
                return 2 * Math.PI * radius;
            }
        }

        public class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(string shapeName, double length, double width) : base(shapeName)
            {
                this.length = length;
                this.width = width;
            }

            public override double findArea()
            {
                return length * width;
            }

            public override double findPerimeter()
            {
                return 2 * (length + width);
            }
        }
    }
}