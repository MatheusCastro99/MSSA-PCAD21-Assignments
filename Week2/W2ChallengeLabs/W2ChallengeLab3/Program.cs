

void MakeTriangle(int width, string fill)
{
    Console.WriteLine("Here is your upside down triangle!");
    for (int i = width; i > 0; i--)
    {
        string repeatable = string.Concat(Enumerable.Repeat(fill, i));
        Console.WriteLine(repeatable);
    }
    Console.WriteLine();

    Console.WriteLine("Here is half of your triangle!");
    for (int i = 1; i <= width; i++)
    {
        string repeatable = string.Concat(Enumerable.Repeat(fill, i));
        Console.WriteLine(repeatable);
        //string[] line = [string.Concat(Enumerable.Repeat(fill, i))];
    }
    Console.WriteLine();

    Console.WriteLine("Here is your entire triangle!");
    for (int i = 1; i <= width; i++)
    {
        int paddingLenght = width - i;
        string padding = new(' ',  paddingLenght);

        string repeatable = string.Concat(Enumerable.Repeat(fill, i));
        Console.WriteLine(padding + repeatable);
    }
}

void getTriangleSymbol()
{
    int triangleWidth = 0;
    string triangleFill = "";

    Console.WriteLine("insert symbol to make a triangle with:");
    triangleFill = Console.ReadLine();
    triangleFill += " ";
    Console.WriteLine();

    Console.WriteLine("insert triangle desired width:");
    triangleWidth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Fill: {triangleFill}\nWidth: {triangleWidth}");
    Console.WriteLine();

    MakeTriangle(triangleWidth, triangleFill);
}

void Initialize()
{
    getTriangleSymbol();
}

Initialize();