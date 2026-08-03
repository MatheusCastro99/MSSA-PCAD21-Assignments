void DisplayMenu()
{
    Console.WriteLine("Select a shape to calculate area:");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Exit");
}


// Main program loop
void Main()
{
    while (true)
    {
        DisplayMenu();
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Enter Circle ID: ");
                string circleId = Console.ReadLine();
                Console.Write("Enter Circle Name: ");
                string circleName = Console.ReadLine();
                Console.Write("Enter Circle Color: ");
                string circleColor = Console.ReadLine();
                Console.Write("Enter Circle Radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle
                {
                    Circleradius = radius
                };
                Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
                break;
            case "2":
                Console.Write("Enter Square ID: ");
                string squareId = Console.ReadLine();
                Console.Write("Enter Square Name: ");
                string squareName = Console.ReadLine();
                Console.Write("Enter Square Color: ");
                string squareColor = Console.ReadLine();
                Console.Write("Enter Square Side Length: ");
                double side = Convert.ToDouble(Console.ReadLine());
                Square square = new Square
                {
                    SquareSide = side
                };
                Console.WriteLine($"Area of Square: {square.CalculateArea()}");
                break;
            case "3":
                Console.WriteLine("Exiting the program.");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

Main();

// Class definitions for Shape, Circle, and Square
public abstract class Shape
{
    public string ShapeID { get; set; }
    public string ShapeName { get; set; }
    public string ShapeColor { get; set; }

    public virtual double CalculateArea()
    {
        return 0;
    }

    //public Shape(string id, string name, string color)
    //{
    //    ShapeID = id;
    //    ShapeName = name;
    //    ShapeColor = color;
    //}
}

public class Circle : Shape
{
    public double Circleradius { get; set; }
    //public Circle(string id, string name, string color, double radius) : base(id, name, color)
    //{
    //    this.Circleradius = radius;
    //}
    public override double CalculateArea()
    {
        double result = Math.PI * Circleradius * Circleradius;
        return result;
    }
}

public class Square : Shape
{
    public double SquareSide { get; set; }
    //public Square(string id, string name, string color, double side) : base(id, name, color)
    //{
    //    this.SquareSide = side;
    //}
    public override double CalculateArea()
    {
        return SquareSide * SquareSide;
    }
}
