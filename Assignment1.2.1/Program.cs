//Assignment 1.2.1 =======================================================================================

Console.WriteLine("Please enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nPlease enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool areEqual(int num1, int num2)
{
    if (num1 == num2) return true;
    else return false;
}

Console.WriteLine(areEqual(firstNum, secondNum) ? "\nThey're equal!!" : "\nThey're not equal");

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();



//Assignment 1.2.2 =======================================================================================

int[] naturalNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int sum = 0;

foreach (var i in naturalNumbers)
{
    sum += i;
}

Console.WriteLine($"the sum of the first 10 natural numbers is {sum}");

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();
