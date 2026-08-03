/*Write a menu driven application to perform calculation functions like addition, 
 subtraction, multiplication, and division. Call them appropriately when user selects the option. 
Give the user the option to continue or exit the program.*/

string choice = "";
Console.WriteLine("Welcome to the Calculator App!");

void RestartProgram()
{
    Console.WriteLine("Do you want to perform another operation? (y/n)");
    string continueChoice = Console.ReadLine();
    if (continueChoice.ToLower() == "y")
    {
        choice = ""; // Reset choice to continue the loop
        Console.WriteLine("");
    }

    else if (continueChoice.ToLower() == "n")
    {
        Console.WriteLine("\nThank you for using the Calculator App!");
        Thread.Sleep(3000); // Wait for 3 seconds before exiting
        choice = "5"; // Set choice to exit the loop
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
        RestartProgram();
    }
}

void DisplayMenu()
{
    Console.WriteLine("Please select an operation:");
    Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
    choice = Console.ReadLine();
}

int AdditionOperation(int num1, int num2)
{
    return num1 + num2;
}

while (choice != "5" && choice != "Exit" && choice != "exit")
{
    DisplayMenu();

    switch (choice)
    {
        case "5" or "Exit" or "exit":
            Console.WriteLine("\nThank you for using the Calculator App!");
            Thread.Sleep(3000); 
            break;

        case "1" or "Addition" or "addition":
            Console.WriteLine("\nEnter the first number:");
            int addNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the second number:");
            int addNum2 = Convert.ToInt32(Console.ReadLine());

            int result = AdditionOperation(addNum1, addNum2);
            Console.WriteLine($"\nThe sum of {addNum1} and {addNum2} is {result}");

            RestartProgram();
            break;

        case "2" or "Subtraction" or "subtraction":
            Console.WriteLine("\nEnter the first number:");
            double subNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter the second number:");
            double subNum2 = Convert.ToDouble(Console.ReadLine());

            double difference = subNum1 - subNum2;
            Console.WriteLine($"\nThe difference between {subNum1} and {subNum2} is {difference}");

            RestartProgram();
            break;

        case "3" or "Multiplication" or "multiplication":
            Console.WriteLine("\nEnter the first number:");
            double mulNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter the second number:");
            double mulNum2 = Convert.ToDouble(Console.ReadLine());

            double product = mulNum1 * mulNum2;
            Console.WriteLine($"\nThe product of {mulNum1} and {mulNum2} is {product}");

            RestartProgram();
            break;

        case "4" or "Division" or "division":
            Console.WriteLine("\nEnter the first number:");
            double divNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter the second number:");
            double divNum2 = Convert.ToDouble(Console.ReadLine());

            if (divNum2 != 0)
            {
                double quotient = divNum1 / divNum2;
                Console.WriteLine($"\nThe quotient of {divNum1} divided by {divNum2} is {quotient}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            RestartProgram();
            break;

        default:
            Console.WriteLine("Invalid input. Please select a valid option.");
            break;
    }
}