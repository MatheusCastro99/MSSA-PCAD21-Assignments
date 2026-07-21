//Create a 2D array to store integers and print them in matrix format with proper formatting.

int[,] Grid =
{
    {123, 2, 345 }, //Row 0
    {46, 5687, 678 }, //Row 1
    {098, 987, 9 } //Row 2
};

int maxNumber = 0;
int width; //Matches the lenght of the largest number in array so we can pad correctly and align table

//Iterates through grid to figure out largest number, and then sets width to how many digits maxNumber has.
foreach (int value in Grid) 
{ 
    if (value > maxNumber)
    {
        maxNumber = value;
    }
}
width = maxNumber.ToString().Length;

//Iterating through Grid and printing it
Console.WriteLine(new string('-', (width + 3) * Grid.GetLength(1) ));

for (int row = 0; row < Grid.GetLength(0); row++) //for loop ensures we can do operations using row and column information
{
    for (int col = 0; col < Grid.GetLength(1); col++)
    {
        Console.Write(Grid[row, col].ToString().PadLeft(width) + " | ");  //Write instead of Writeline because we want rows to display in a single line
    }
    Console.WriteLine(); //Ensures cursors get moved to a new line after iterating through row. We want columns in different lines.
}

Console.WriteLine(new string('-', (width + 3) * Grid.GetLength(1)));

