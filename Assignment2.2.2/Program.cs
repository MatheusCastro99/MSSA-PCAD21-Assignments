string choice;

void DisplayMenu()
{
    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. Add two integers\n2. Add two decimals\n3. Multiply two floats\n4. Multiply three floats");
    choice = Console.ReadLine();

    HandleUserChoice(choice);
}

void ResetChoice()
{
    string doAgain;
    
    Console.WriteLine("Do you want to perform another operation? (y/n)");
    doAgain = Console.ReadLine();

    if (doAgain.ToLower() == "y")
    {
        choice = "";
        DisplayMenu();
    }
    else
    {
        Console.WriteLine("Thank you for using the program. Goodbye!");
        Thread.Sleep(2000); // Wait for 2 seconds before exiting
    }
}

void HandleUserChoice(string userChoice)
{
    switch (userChoice)
    {
        case "1":
            Console.WriteLine("Enter two integers:");
            int intA = Convert.ToInt32(Console.ReadLine());
            int intB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result: {SimpleOperations.Add(intA, intB)}");
            break;
        case "2":
            Console.WriteLine("Enter two decimals:");
            decimal decA = Convert.ToDecimal(Console.ReadLine());
            decimal decB = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Result: {SimpleOperations.Add(decA, decB)}");
            break;
        case "3":
            Console.WriteLine("Enter two floats:");
            float floatA = Convert.ToSingle(Console.ReadLine());
            float floatB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Result: {SimpleOperations.Multiply(floatA, floatB)}");
            break;
        case "4":
            Console.WriteLine("Enter three floats:");
            float floatC = Convert.ToSingle(Console.ReadLine());
            float floatD = Convert.ToSingle(Console.ReadLine());
            float floatE = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Result: {SimpleOperations.Multiply(floatC, floatD, floatE)}");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again selecting from the equivalent numbers.");
            break;
    }

    ResetChoice();
}

DisplayMenu();

public class SimpleOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    public static float Multiply(float a, float b)
    {
        return a * b;
    }

    public static float Multiply(float a, float b, float c)
    {
        return a * b * c;
    }
}