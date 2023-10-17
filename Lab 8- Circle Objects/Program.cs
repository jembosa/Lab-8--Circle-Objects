namespace Lab_8__Circle_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;

            while (true)
            {
                while (true)
                {



                    Console.WriteLine("Please enter radius of circle: ");
                    if (double.TryParse(Console.ReadLine(), out radius))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Please enter valid number");
                    }

                }
                Circle circle = new Circle(radius);

                bool grow = true;

                while (grow)
                {
                    Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
                    Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
                    Console.WriteLine($"Area: {circle.CalculateArea()}");

                    Console.WriteLine("Would you like the circle to grow? 'y/n'");
                    string response = Console.ReadLine();

                    if (response.ToLower() == "y")
                    {
                        circle.Grow();
                        Console.WriteLine("Kooloo-Limpah! The circle has Grown!");
                        Console.WriteLine($"New Radius: {circle.GetRadius()}");
                    }
                    else
                    {
                        Console.WriteLine($"Goodbye. The circles final radius is: {circle.GetRadius()}");
                        grow = false;
                    }
                }
                Console.WriteLine("Do you want to start over? y/n");
                string startover = Console.ReadLine();
                if (startover.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}

