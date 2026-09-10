//Write a program in C# Sharp to find the +ve (positive) numbers from a list of numbers using where conditions in LINQ Query.

//Example
//Input: { 2, -1, 3, -3, 10, -200}
//Expected output: { 2, 3, 10}

//Constraints:
//Use where condition in LINQ
//input: int[] / output: int[]

int[] originalNumbers = new int[]
{
    2, 
    -1, 
    3, 
    -3, 
    10, 
    -200
};

int[] filteredNumbers = originalNumbers.Where(x => x > 0).ToArray<int>();

Console.WriteLine(string.Join(", ", filteredNumbers));