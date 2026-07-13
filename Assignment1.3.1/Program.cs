//Write a program in C# to calculate area of triangle, square and rectangle. 
//  Write 3 different functions for each shape to take dimensions of figure and display the area. 
//  You may create menus.

string userChoice = "";

void DisplayMenu()
{
    Console.WriteLine("Choose a shape to calculate area:");
    Console.WriteLine("1. Triangle\n2. Square\n3. Rectangle\n4. Circle\n5. Exit");
    userChoice = Console.ReadLine();
}

void ResetProgram()
{
    userChoice = "";
    string goAgain;

    Console.WriteLine("Do you want to calculate another area? (y/n)");
    goAgain = Console.ReadLine();

    if (goAgain == "y" || goAgain == "Y")
    {
        // Console.Clear();
        return;
    }
    else if (goAgain == "n" || goAgain == "N")
    {
        userChoice = "5";
        Console.WriteLine("Exiting the program.");
        Thread.Sleep(3000);
        return;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
        ResetProgram();
    }
} //Reset userChoice and gives the option to conttinue operations or exit the program

void userChoiceHandler()
{
    switch (userChoice)
    {
        case "1" or "Triangle" or "triangle":
            CalculateTriangleArea();
            break;
        case "2" or "Square" or "square":
            CalculateSquareArea();
            break;
        case "3" or "Rectangle" or "rectangle":
            CalculateRectangleArea();
            break;
        case "4" or "Circle" or "circle":
            CalculateCircleArea();
            break;
        case "5" or "Exit" or "exit":
            Console.WriteLine("Exiting the program.");
            Thread.Sleep(3000);
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again from one of the options.");
            break;
    }
} //Handles the choice provided by the user through the DisplayMenu() method

void CalculateTriangleArea()
{
    Console.WriteLine("Enter the base of the triangle:");
    double baseLength = double.TryParse(Console.ReadLine(), out double baseResult) ? baseResult : 0;
    Console.WriteLine("Enter the height of the triangle:");
    double height = double.TryParse(Console.ReadLine(), out double heightResult) ? heightResult : 0;
    double area = 0.5 * baseLength * height;

    Console.WriteLine($"The area of the triangle is: {area}");
    ResetProgram();
} //Used TryParse to prevent errors.

void CalculateSquareArea()
{
    Console.WriteLine("Enter the side length of the square:");
    double side = Convert.ToDouble(Console.ReadLine());
    double area = side * side;

    Console.WriteLine($"The area of the square is: {area}");
    ResetProgram();
}

void CalculateRectangleArea()
{
    Console.WriteLine("Enter the length of the rectangle:");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the width of the rectangle:");
    double width = Convert.ToDouble(Console.ReadLine());
    double area = length * width;

    Console.WriteLine($"The area of the rectangle is: {area}");
    ResetProgram();
}

void CalculateCircleArea()
{
    Console.WriteLine("Enter the radius of the circle:");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * radius * radius;

    Console.WriteLine($"The area of the circle is: {area}");
    ResetProgram();
}

while (userChoice != "5" && userChoice != "Exit" && userChoice != "exit")
{
    DisplayMenu();
    userChoiceHandler();
}