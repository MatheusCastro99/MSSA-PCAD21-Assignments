//Implement merge sort on an unsorted array of numbers. Take the array input from user.

//Different methods to separate arrays and then merge them

//Separate:
//Identify middle element, separate into subarrays left and right
//recursive until subarrays have one element

//Merge:
//Shuffling strategy - for each recursion, iterate through subawways merging pointers in lock-step
//result will go into a new merged array, which will be passed up for the next step

Console.WriteLine("Input elements (whole numbers) separated by a coma and space \", \"");
string arrayInput = Console.ReadLine();
int[] OriginalArr = arrayInput
    .Split(", ") //Split input into substrings at each ", "
    .Select(int.Parse) //Go through substrings trying to parse int elements to int
    .ToArray(); //Conveys the result into an array

Console.WriteLine($"Original array: {string.Join(',', OriginalArr)}");
MergeSortDivide(OriginalArr, 0, OriginalArr.Length-1);
Console.WriteLine($"after Merge sort: {string.Join(',', OriginalArr)}");

void MergeSortDivide(int[] array, int left, int right) //Left and Right pointers to define the limits of the subArrays
{
    if (left >= right) //pointers crossed
    {
        return;
    }

    int middle = left + (right - left) / 2;

    MergeSortDivide(array, left, middle); //Recursive action towards left of array
    MergeSortDivide(array, middle+1, right); //Towards right of array

    Merge(array, left, middle, right);
}

void Merge(int[] numbers, int left, int middle, int right)
{
    //determines the size of each new array and initializes them
    int leftSize = middle - left + 1;
    int rightSize = right - middle;

    int[] leftArray = new int[leftSize];
    int[] rightArray = new int[rightSize];

    //populates the new arrays (not sorted yet)
    for (int i = 0; i < leftSize; i++)
        leftArray[i] = numbers[left + i];

    for (int j = 0; j < rightSize; j++)
        rightArray[j] = numbers[middle + 1 + j];

    //Indexes (pointers) for the merge
    int leftIndex = 0, rightIndex = 0; //equivalent to i, j
    int mergedIndex = left; //left == beginning of array

    //Sub arrays iteration preventing out of bounds
    while (leftIndex < leftSize && rightIndex < rightSize)
    {
        if (leftArray[leftIndex] <= rightArray[rightIndex]) //actual sorting part
        {
            numbers[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            numbers[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
        }

        mergedIndex++; //advances main array pointer
    }

    //Takes care of remainders (if one array is bigger than the other)
    while (leftIndex < leftSize)
    {
        numbers[mergedIndex] = leftArray[leftIndex];
        leftIndex++;
        mergedIndex++;
    }

    while (rightIndex < rightSize)
    {
        numbers[mergedIndex] = rightArray[rightIndex];
        rightIndex++;
        mergedIndex++;
    }
}