namespace Solid__Principles
{
    public class OCP
    {
        // Example adhering to OCP
        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double Area()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public class Square : Shape
        {
            public double SideLength { get; set; }

            public override double Area()
            {
                return Math.Pow(SideLength, 2);
            }
        }

    }
}
