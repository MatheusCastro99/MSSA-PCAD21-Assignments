//Implement fibbonacci algorithm recursively and iteratively

//Through Recursion
Console.WriteLine("Fibonacci series using recursion:");

int iterations = 8;

for (int i = 0; i < iterations; i++)
{
    Console.Write(FibbonacciRecursive(i) + " "); //Calls on method starting at 0 and going up 
}
Console.WriteLine();

int FibbonacciRecursive(int n)
{
    if (n <=1) //First and Second calls fall here, simply returning 0 and 1
    {
        return n;
    }

    return FibbonacciRecursive(n - 1) + FibbonacciRecursive(n - 2); //rest of the call fall here, returning the sum of the previous 2 numbers
}

Console.WriteLine("\n=======================================\n");

//Through Iterations
Console.WriteLine("Fibonacci series using iterative approach:");

int val1 = 0;
int val2 = 1; //0 and 1 are seeds, this loop cannot start at 0 or 1;
int val3;
int n;

n = 8; //number of iterations

Console.Write(val1 + " " + val2 + " "); //Starts iteration manually

for (int i = 2; i < n; i++) //Call on for loop starting at i == 2
{
    val3 = val1 + val2;
    Console.Write(val3 + " ");
    val1 = val2; //Sliding window methodology, sliding val variables forward one slot so val3 can be recalculated
    val2 = val3;
}