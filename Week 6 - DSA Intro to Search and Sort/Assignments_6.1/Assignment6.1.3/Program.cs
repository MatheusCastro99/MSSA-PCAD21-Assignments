#region PROBLEM, CONSTRAINTS, AND THOUGHTS
//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

//Constraints:
//Must do this in-place without making a copy of the array.
//Must maintain the relative order of the non-zero elements

//Thoughts:
//Switching in place does not work since I have to maintain order of elements
//Iterate through array checking every number for n == 0
//keep a count of 0's found (simple int)
//for each 0 found, count++ and remove that 0 from array
//At end of iteration, add count's 0 to the end of array
#endregion

//First variables for different methods
int[] nums = [0, 1, 0, 0, 3, 12];
int[] numsArrayList = nums;
int[] numsPointer = nums;

#region LINQ SOLUTION
int zeroCount = nums.Count(0); //Counts the number of "0" occurrences

Console.WriteLine($"array: {string.Join(", ", nums)}\n0 count: {zeroCount}");

nums = nums.Where(val => val != 0).ToArray(); //Removes all "0" from array

for  (int i = 0; i < zeroCount; i++)
{
    nums = nums.Append(0).ToArray(); //Appends 0 to the end of array as many times as zeroCount
}

Console.WriteLine($"new array: {string.Join(", ", nums)}");
#endregion

#region LIST SOLUTION
Console.WriteLine("\nUsing List: ");
Console.WriteLine($"array: {string.Join(", ", numsArrayList)}");

var list = numsArrayList.ToList();

list.RemoveAll(x => x == 0); //Iterates through list removing every x when x == 0
list.AddRange(Enumerable.Repeat(0, numsArrayList.Count(0))); //adds 0 the amount of times that numsArrayList.Count(0) returns

numsArrayList = list.ToArray();

Console.WriteLine($"New array: {string.Join(", ", numsArrayList)}\n0 count: {numsArrayList.Count(0)}");
#endregion

#region POINTER SOLUTION
Console.WriteLine("\nUsing Pointers: ");
Console.WriteLine($"array: {string.Join(", ", numsPointer)}");

int j = 0;

for (int i = 0; i < numsPointer.Length; i++)
{
    if (numsPointer[i] != 0) //For each number different than 0, we want to swap places with the last 0 found
    {
        var temp = numsPointer[j]; // stores first 0 found in temp
        numsPointer[j] = numsPointer[i]; //moves non-0 element to first 0 element
        numsPointer[i] = temp; //substitutes nums[i] with 0

        j++; //moves 0 pointer forward
    }
    //if nums[i] == 0, j pointer stays in place

    //Each iteration will "bump" zero with first non-0 element found
}

Console.WriteLine($"New array: {string.Join(", ", numsPointer)}");
#endregion
