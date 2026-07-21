//Write a function that takes 4 numbers as input to calculate the total and average.
//(Make use of params array to pass arguments and out parameters to return both total and average to main method).

//declare variables
int[] numbers = new int[4];
double average;
int total;

//Populate numbers Array
Console.WriteLine("Enter First number:");
numbers[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second number:");
numbers[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Third number:");
numbers[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Fourth number:");
numbers[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//Gets Average and Total through out paremeters
void CalculateTotalAndAverage(int[] array, out double MethodScopeAverage, out int MethodScopeTotal)
{
    int sum = 0;
    foreach (int i in array)
    {
        sum += i;
    }

    MethodScopeTotal = sum;
    MethodScopeAverage = (double)sum / array.Length;
}

//Out arguments to get results
CalculateTotalAndAverage(numbers, out average, out total);

//Prints and formats
Console.WriteLine($"The average of {string.Join(", ", numbers)} is: {average:F2}");
Console.WriteLine($"The total is {total}");

//Alternative built-in methods
//Console.WriteLine($"Total: {numbers.Sum()}\nAverage: {numbers.Average()}");