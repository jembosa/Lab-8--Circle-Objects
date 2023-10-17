namespace Lab_8__Circle_Objects
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }


        public double CalculateDiameter()
        {

            return 2 * Radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetRadius()
        {
            return Radius;
        }

        public void Grow()
        {
            Radius = Radius * 2;
        }
    }
}








