//Write a program in C# Sharp to count the frequency of each element of an array and also prints all unique elements.

int arraySize = 0;
Dictionary<int, int> numbers = new(arraySize);
CountFrequency();
FindUniques();

void CountFrequency()
{
    Console.WriteLine("Enter array size: ");
    arraySize = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine("input value: ");
        int newValue = Convert.ToInt32(Console.ReadLine());

        if (numbers.ContainsKey(newValue)) //Performs the check when assigning the new element to the dictionary
        {
            numbers[newValue] += 1; //Increasing its value by 1 if existing
        }
        else
        {
            numbers[newValue] = 1; //Or creating a new key to store the element, with initial value (count) 1
        }

        Console.WriteLine($"Element: {newValue}, Count: {numbers[newValue]}\n");
    }
}

void FindUniques ()
{
    Console.WriteLine("\n================================================\n");

    foreach (var i in numbers)
    {
        if (i.Value == 1) //Value is being used to monitor the frequency of the element, so a Value == 1 means the element is unique
        {
            Console.Write($"{i.Key}, ");
        }
    }
}
