int[] naturalNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int sum = 0;

foreach (var i in naturalNumbers)
{
    sum += i;
}

Console.WriteLine($"the sum of the first 10 natural numbers is {sum}");

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();