//Write a program in C# Sharp for addition of two Matrices of same size.

//Declare grids and variables
int[,] grid1 =
{
    {1, 2 },
    {3, 400 }
};

int[,] grid2 =
{
    {5, 6  },
    {7, 82 },
};

int[,] gridSum = SumGrids(grid1, grid2);

int width = DetermineMaxWidth(grid1, grid2);

//Display Grids
Console.WriteLine("Grid 1:");
DisplayGrid(grid1);

Console.WriteLine("Grid 2:");
DisplayGrid(grid2);

Console.WriteLine("Sum of the Grids:");
DisplayGrid(gridSum);

// Determine largest number size ==============================================================================================================================
int DetermineMaxWidth(int[,] grid1, int[,] grid2) 
{
    int maxNumber = 0;
    for (int row = 0; row < grid1.GetLength(0); row++)
    {
        for (int col = 0; col < grid1.GetLength(1); col++)
        {
            if (grid1[row, col] > maxNumber)
            {
                maxNumber = grid1[row, col];
            }

            if (grid2[row, col] > maxNumber)
            {
                maxNumber = grid2[row, col];
            }
        }
    }
    return maxNumber.ToString().Length;
}

// Display Grids Method =======================================================================================================================================
void DisplayGrid(int[,] grid)
{
    
    Console.WriteLine(new string('-', (width + 3) * grid.GetLength(1)));

    for (int row = 0; row < grid.GetLength(0); row++)
    {
        for (int col = 0; col < grid.GetLength(1); col++)
        {
            Console.Write(grid[row, col].ToString().PadLeft(width) + " | ");
        }
        Console.WriteLine();
    }

    Console.WriteLine(new string('-', (width + 3) * grid.GetLength(1)));
    Console.WriteLine();
}

//Math part ====================================================================================================================================================
int[,] SumGrids(int[,] FirstGrid,  int[,] SecGrid)
{
    int[,] sum = new int[2,2];

    for (int row = 0; row < FirstGrid.GetLength(0); row++)
    {
        for (int col = 0; col < FirstGrid.GetLength(1); col++)
        {
            int newNumber = FirstGrid[row, col] + SecGrid[row, col]; //We Iterate through grid1, summing each value to its grid2 index correspondent and assigning it to a var newNumber
            sum[row, col] = newNumber;
        }
    }

    return sum;
}