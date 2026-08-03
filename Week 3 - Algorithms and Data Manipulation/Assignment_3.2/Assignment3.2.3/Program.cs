//Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.

CircleOps circle1 = new(25);
CircleOps circle2 = new(15);

CircleOps sum = circle1 + circle2;
CircleOps sub = circle1 - circle2;

Console.WriteLine("Adding circle 1 and 2 areas:");
Console.WriteLine(sum.Area);

Console.WriteLine("Subtracting circle 1 and 2 areas:");
Console.WriteLine(sub.Area);
public class CircleOps
{
    public double Area {  get; set; }

    public CircleOps(double area)
    {
        Area = area;
    }

    public static CircleOps operator +(CircleOps a1, CircleOps a2) =>
        new CircleOps(a1.Area + a2.Area);
    

    public static CircleOps operator -(CircleOps a1, CircleOps a2)
    {
        if (a1.Area < a2.Area)
        {
            return new CircleOps(0); //Negative Areas are not a thing
        }
        else
        {
            return new CircleOps(a1.Area - a2.Area);
        }
    }
}


