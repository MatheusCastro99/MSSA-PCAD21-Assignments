Console.WriteLine("Welcome to the Tip Calculator!");

//Getting in the habit of declaring methods before the main code block. This is a good practice for readability and organization.
//Also getting in the habit of using adequate variable scopes, with variables being declared and accessed on a need-to-know basis

void CalculateTip(double billSubTotal)
{
    double tipPercentage;
    double tipAmount;

    Console.WriteLine("Enter the tip percentage (e.g., 15 for 15%):");
    tipPercentage = Convert.ToDouble(Console.ReadLine());

    tipAmount = billSubTotal * (tipPercentage / 100);
    Console.WriteLine($"your tip amount is: ${tipAmount:F2} ");
    Console.WriteLine("Accept tip amount? (yes/no)");

    if (Console.ReadLine().ToLower() == "yes")
    {
        CalculateBillTotal(billSubTotal, tipAmount);
    }
    else
    {
        CalculateTip(billSubTotal);
    }
}

void CalculateBillTotal(double billSubTotal, double tipAmount)
{
    double billTotal;

    billTotal = billSubTotal + tipAmount;
    Console.WriteLine($"Your total bill amount is: ${billTotal:F2}");
}

while (true)
{
    double billsubTotal;
    string userChoice = "";

    Console.WriteLine("Enter the bill subtotal (or type 'exit' to quit):");
    userChoice = Console.ReadLine();

    if (Double.TryParse(userChoice, out billsubTotal))
    {
        CalculateTip(billsubTotal);
    }
    else
    {
        if (userChoice.ToLower() == "exit")
        {
            Console.WriteLine("Thank you for using the Tip Calculator! Goodbye!");
            break; // Exit the loop and end the program if user types 'exit'
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the bill subtotal.");
        }
    }
    
    Console.WriteLine("Would you like to calculate another tip? (yes/no)");
    if (Console.ReadLine().ToLower() != "yes")
    {
        Console.WriteLine("Thank you for using the Tip Calculator! Goodbye!");
        break;
    } // Exit the loop and end the program if user types anything other than '[Yy]es'
}
