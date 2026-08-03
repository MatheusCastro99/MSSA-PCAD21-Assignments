// Assignment 1.3.2 ===============================================================================================================

int[] array1 = new int[5]; // Declaration and initialization with size
array1[0] = 1;
array1[1] = 2;
Console.WriteLine(array1); // Output: System.Int32[]
Console.WriteLine(string.Join(", ", array1)); // Output: 1, 2, 0, 0, 0
Console.WriteLine(array1[1]);
array1[0] = 1 + 2;

string[] array2 = new string[3];
array2[0] = "Hello";
array2[1] = "World";
Console.WriteLine(string.Join(", ", array2)); // Output: Hello, World, .
array2[2] = string.Join("", array2[1].Reverse());
Console.WriteLine(string.Join(", ", array2));


// Assignment 1.3.3 ===============================================================================================================
Console.WriteLine();

int arraySize;
int temp;
int[] ints;

Console.WriteLine("Enter the size of the array:");
arraySize = Convert.ToInt32(Console.ReadLine());
ints = new int[arraySize];

//int[] reverseInts = new int[arraySize];

for  (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine($"Enter value for index {i}:");
    var input = Console.ReadLine();
    int.TryParse(input, out ints[i]);
}
Console.WriteLine($"The values in the array are: {string.Join(", ", ints)}");

for (int i = 0;i < ints.Length;i++)
{
    if (i < ints.Length / 2)
    {
        temp = ints[i];
        ints[i] = ints[ints.Length - 1 - i];
        ints[ints.Length - 1 - i] = temp;
    }
}
Console.WriteLine($"The values in the reversed array are: {string.Join(", ", ints)}");

//for (int  i = 0;  i < ints.Length;  i++)
//{
//    reverseInts[i] = ints[ints.Length - 1 - i];
//}
//Console.WriteLine($"The values in the reversed array are: {string.Join(", ", reverseInts)}");

Thread.Sleep(5000);