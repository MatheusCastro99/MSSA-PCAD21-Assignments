//Write a program in C# Sharp to calculate and print the Electricity bill of a given customer.
//The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer.

//The charge are as follows: (you may change the charge sheet values)
//up to 199: 1.20
//200 and above but less than 400: 1.50
//400 and above but less than 600: 1.80
//600 and above: 2.00

//If bill exceeds $ 400 then a surcharge of 15% will be charged.

//THOUGHTS: Cascaded If - else statements tracking units left after each tier
// Brute force route, lenghty, not elegant, complex to visualize, but fast due to simplicity and it works

string userID;
string name;
double unitsConsumed = 0;

Console.WriteLine("Enter User ID: ");
userID = Console.ReadLine();

Console.WriteLine("Enter Customer Name: ");
name = Console.ReadLine();

Console.WriteLine("Enter units consumed: ");
double.TryParse(Console.ReadLine(), out unitsConsumed);

calculateBill(unitsConsumed);

double calculateBill(double units)
{
    Console.WriteLine("\n=============================================================\n");
    Console.WriteLine($"UserID: {userID}");
    Console.WriteLine($"Name: {name}\n");
    double tier1 = 0;
    double tier2 = 0;
    double tier3 = 0;
    double tier4 = 0;

    double total = 0;

    double unitsLeft = units;

    if (units <= 199)
    {
        tier1 = units * 1.20;
        total = tier1;

        Console.WriteLine($"Tier 1 Consume: {tier1:F2}");
    }
    else //Units >= 200
    {
        tier1 = 199 * 1.2;
        unitsLeft -= 199;
        if (units < 400) //Units >= 200 && <400 
        {
            tier2 = unitsLeft * 1.5;
            total = tier1 + tier2;

            Console.WriteLine($"Tier 1 Consume: {tier1:F2}");
            Console.WriteLine($"Tier 2 Consume: {tier2:F2}");
        }
        else //Units >= 200 && >= 400
        {
            tier2 = 199 * 1.5;
            unitsLeft -= 199;
            if (units < 600) //Units >=400 && <600
            {
                tier3 = unitsLeft * 1.8;
                total = tier1 + tier2 + tier3;

                Console.WriteLine($"Tier 1 Consume: {tier1:F2}");
                Console.WriteLine($"Tier 2 Consume: {tier2:F2}");
                Console.WriteLine($"Tier 3 Consume: {tier3:F2}");
            }
            else //Entered on units >=600
            {
                tier3 = 199 * 1.8;
                unitsLeft -= 199;

                tier4 = unitsLeft * 2;
                total = tier1 + tier2 + tier3 + tier4;

                Console.WriteLine($"Tier 1 Consume: {tier1:F2}");
                Console.WriteLine($"Tier 2 Consume: {tier2:F2}");
                Console.WriteLine($"Tier 3 Consume: {tier3:F2}");
                Console.WriteLine($"Tier 4 Consume: {tier4:F2}");
            }
        }
    }

    if (total > 400)
    {
        double surcharge = total * 0.15;
        Console.WriteLine($"\nSubtotal: {total:F2}"); //Displays total before adding the surcharge to it

        total += surcharge;
        Console.WriteLine($"Surcharge ($400+): {surcharge:F2}");
    }

    Console.WriteLine($"Total: {total:F2}");
    return total;
}