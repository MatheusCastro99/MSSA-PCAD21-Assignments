//Create a function that finds the index of a given item in the array
//Search(int[] array, int targetNumber) -> returns index of targetNumber or -1 if targetNumber not in array

int[] array;
int targetNum;

Console.Write("How many numbers do you want to input? ");
array = new int[Convert.ToInt32(Console.ReadLine())];
BuildArray();

Console.Write("What number do you want to find? ");
targetNum = Convert.ToInt32(Console.ReadLine());

Search(array, targetNum);

int Search (int[] numbers, int targetNum)
{
    int targetIndex = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == targetNum)
        {
            Console.WriteLine($"The number {targetNum} is at index {i}");

            targetIndex = i;
            return targetIndex;
        }
    }

    Console.WriteLine($"Target number not found. {targetIndex} returned");
    return targetIndex;
}

void BuildArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Enter number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}