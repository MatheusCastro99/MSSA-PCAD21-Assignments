
void ComparePoints()
{
    Point p1 = new Point(1, 2);
    Point p2 = new Point(3, 4);

    if (p1.X < p2.X)
    {
        Console.WriteLine("p1 is to the left of p2.");
    }
    else if (p1.X > p2.X) 
    { 
        Console.WriteLine("p1 is to the right of p2."); 
    }
    else
    {
        Console.WriteLine("p1 and p2 are vertically aligned.");
    }
}

ComparePoints();

struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
   
}