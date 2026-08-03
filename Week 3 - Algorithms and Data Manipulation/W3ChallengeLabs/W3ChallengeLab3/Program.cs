//PROBLEM:
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//GIVENS AND CONSTRAINTS
// You may assume that each input would have exactly one solution, and you may not use the same element twice.

//THOUGHTS:
// Create nested loop that will iterate each index at each index position
// Because X + Y and Y + X are the same, each inner loop index only need to iterate through those in front of outer loop current index
//    - Set inner loop index to start at outer loop's index
//    - Exercise constraint: May not use the same element twice.
//    - Inner loop == (outer loop + 1)
//    - Last index does not need to be checked because it was already tested agains all other indexes

int[] nums;
int targetNum;

Console.Write("How many numbers do you want to input? ");
nums = new int[Convert.ToInt32(Console.ReadLine())];
BuildArray();

Console.Write("What sum do you want to find? ");
targetNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

FindSum(nums, targetNum);

void FindSum (int[] nums, int targetNum)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i+1; j < nums.Length; j++)  //j = i+1 because we do not need to check backwards or the same element
        {
            if ((nums[i] + nums[j]) == targetNum)
            {
                Console.WriteLine("Those two indexes value add to the Target Number: ");
                Console.WriteLine($"[{i}, {j}]");
                Console.WriteLine($"The respective values are: {nums[i]}, and {nums[j]}");

                return;
            }
        }
    }

    Console.WriteLine($"No addition combination in this list on number returns your target Number. -1");
}

void BuildArray()
{
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write("Enter number: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}