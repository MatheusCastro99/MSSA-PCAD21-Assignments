//Assignment2.4.1 =======================================================================================================================

Console.WriteLine("Input the number of elements to be stored:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] arrayElements = new int[arraySize];
int arraySum = 0;

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Enter element number {i+1}");
    int newNumber = Convert.ToInt32(Console.ReadLine());

    arrayElements[i] = newNumber;
}
Console.WriteLine();
Console.WriteLine($"The elements entered are: {string.Join(", ", arrayElements)}");

foreach (int element in arrayElements)
{
    arraySum += element;
}
Console.WriteLine($"The sum of these elements is: {arraySum}");

Console.ReadLine(); //Keeps console open

//Assignment2.4.2 =======================================================================================================================

int[] numbersList = [25, 63, 10];
int largestNum = 0;

foreach (int number in numbersList)
{
    if (number > largestNum)
    {
        largestNum = number;
    }
}

Console.WriteLine($"The largest number out of {string.Join(", ", numbersList)} is {largestNum}");
Console.ReadLine();

//Assignment2.4.3 =======================================================================================================================

int x = 0;
int y = 0;
int[] point = new int[2];
Console.WriteLine("enter an X and Y coordinate to check in which quadrant the point lies");

Console.WriteLine("X coordinate: ");
x = Convert.ToInt32(Console.ReadLine());
point[0] = x;

Console.WriteLine("Y coordinate: ");
y = Convert.ToInt32(Console.ReadLine());
point[1] = y;

string quadrant = point switch
{
    [>0, >0] => "Quadrant 1",
    [<0, >0] => "Quadrant 2",
    [<0, <0] => "Quadrant 3",
    [>0, <0] => "Quadrant 4",

    [0, 0] => "Origin",
    [_, 0] => "X-axis",
    [0, _] => "Y-axis",

    _ => "Invalid entry"
};

Console.WriteLine($"The point at X: {point[0]} and Y: {point[1]} is on the {quadrant}");
Console.ReadLine();