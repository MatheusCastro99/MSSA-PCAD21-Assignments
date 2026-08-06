#region ASSIGNMENT 5.4.1
//Write a program in C# Sharp to display the individual digits of a given number using recursion.
//Constraint: recursion

using System.Drawing;

Console.WriteLine("Input any integer number");
int number = Convert.ToInt32(Console.ReadLine());

PrintRecursive(number);

void PrintRecursive(int  number)
{
    if (number == 0)
    {
        return;
    }

    int digit = number % 10;


    PrintRecursive(number /= 10);
    Console.Write($"{digit}, ");
}
#endregion

Console.WriteLine("\n");

#region ASSIGNMENT 5.4.2
//Write a C# Sharp program to find the sum of the right diagonals of a matrix.

//Constraints: square matrix so same numbers of rows and columns
//right diagonal: add elements where row == column starting at 1,1 and ending at Length-1, Length-1

Console.WriteLine("Enter the size of square matrix: ");
int matrixSize = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];

Console.WriteLine("Input elements into matrix");
PopulateMatrix();

DisplayMatrix();

Console.WriteLine($"The sum of this square matrix right diagonal is: {CalculateDiagSum()}");

void PopulateMatrix()
{
    for (int i = 0; i < matrixSize; i++) //rows
    {
        for (int j = 0; j < matrixSize; j++) //columns
        {
            Console.Write($"element - [{i}],[{j}] : ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

int CalculateDiagSum()
{
    int diagSum = 0;
    for (int i = 0; i < matrixSize; i++) //Because square diagonals means elements in which rows == columns (i==j), I do not need a nested loop to get the diagonal values
    {
        diagSum += matrix[i, i];
    }

    return diagSum;
}

void DisplayMatrix()
{
    Console.WriteLine("\nThe matrix is :");
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


#endregion