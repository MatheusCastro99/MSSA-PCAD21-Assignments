//You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

//You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
//DO NOT allocate another 2D matrix and do the rotation.

Console.WriteLine("Write matrix size: ");

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

//i = rows, j = columnspr
for (int i = 0; i < n; i++) // Iterate through matrix assigning values
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = i + j; // Actual values assignment
    }
}

Console.WriteLine("Matrix:");
PrintMatrix(matrix);

Console.WriteLine("Rotating Matrix:");
RotateInPlace(matrix);
PrintMatrix(matrix);


void PrintMatrix(int[,] mat)
{
    Console.WriteLine();

    // rows = Dimension 0
    int rows = mat.GetLength(0);

    // Columns = Dimension 1
    int cols = mat.GetLength(1);

    // Outer loop iterates through each row
    for (int i = 0; i < rows; i++)
    {
        // Inner loop iterates through elements of the current row (each columns of row)
        for (int j = 0; j < cols; j++)
        {
            // Print element followed by a tab space for clean columns
            Console.Write(mat[i, j] + "\t");
        }

        // Move to the next line after completing a row
        Console.WriteLine();
    }
}

void RotateInPlace(int[,] matrix)
{
    // Step 1: Transpose (Mirror) the matrix on its main diagonal (180dg flip)
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++) // j = i+1 ensures that you only swap elements above the main diagonal, 
        {                               // similar to lenght/2 when reversing arrays
            int temp = matrix[i, j]; //3-corner swap
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }

    // Step 2: Reverse each row (same effect of rotating back 90dg)
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n / 2; j++) // reversing rows so we stop at n/2
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, n - 1 - j]; //((n-1) - j) gets the exact opposite member
            matrix[i, n - 1 - j] = temp;
        }
    }
}