#region WEEK 5 CHALLENGE LAB 1
//Given a non - empty array of integers nums, every element appears twice except for one. Find that single one.
//Thoughts: HASHSET!!

int[] nums = [4, 1, 2, 1, 2];
HashSet<int> unique = new();

for(int i = 0; i<nums.Length; i++)
{
    if (!unique.Add(nums[i])) //Condition will pass if HashSet fails to add nums[i], indicating that it is a duplicate and preventing it from entering the set
    {
        unique.Remove(nums[i]); //Removes counter duplicate already in the set
    }
}
Console.WriteLine(unique.First<int>()); //Exercise guarantees that only one element is unique, so it will be the only element in the Hash.
#endregion

#region WEEK 5 CHALLENGE LAB 2
//Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

//Array will always contain 0. Min == 0 always.
//It can be expected that nums.length == n. In [0,2] (missing 1) n==2 and Length ==2

//Could start by sorting, then check if nums[i+1] == nums[i] + 1.
//Maybe I could skip sorting using Contains. n=2, [0, 2] (missing 1), iterate through array checking if Array.Contains(i)

//If Contains is off-limits. I could add all numbers from 0, n to a hashSet, then iterate through the array trying to read them
//Similar to checking duplicates, I could then remove the number that triggered the failed conditions
//The hashset would be left with only the missing number

int[] ex1 = [3, 0, 1]; //n == 3, missing 2
int[] ex2 = [0, 1]; //n == 2, missing 2
int[] ex3 = [9, 6, 4, 2, 3, 5, 7, 0, 1]; //n == 9, missing 8

//FindMissingContains(ex1);
//FindMissingContains(ex2);
//FindMissingContains(ex3);

FindMissingHash(ex1);
FindMissingHash(ex2);
FindMissingHash(ex3);

void FindMissingContains(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (!nums.Contains<int>(nums.Length)) //Exception case where missing number == n
        {
            Console.WriteLine($"{nums.Length} is missing from {string.Join(", ", nums)}");
            break;
        }

        if (!nums.Contains<int>(i))
        {
            Console.WriteLine($"{i} is missing from {string.Join(", ", nums)}");
            break;  //Breaks out of loop as soon as missing number is found
        }
    }

    Console.WriteLine();
}

void FindMissingHash(int[] nums)
{
    HashSet<int> numsHash = new();

    for (int i = 0;i < nums.Length;i++) //nums.Length is n. So this loop adds all numbers from o to n range into the Hash
    {
        numsHash.Add(i);
    }

    foreach (int num in nums) //Now that Hash is loaded, we will remove duplicates between hashSet and nums[]
    {
        if (!numsHash.Add(num)) //Returns true if element is added successfully, False if element is already present (duplicate).
        {
            numsHash.Remove(num); //Because I inverted the check with !, every number present in nums[] will fall here, being removed from the Hash
                                  //The only number left in the HashSet will be the number missing in nums[]. The one we are looking for.
        }
    }

    if(numsHash.Count == 0) //Case where missing number is the last in the range, n
    {
        numsHash.Add(nums.Length);
    }

    Console.WriteLine(numsHash.First<int>());
}
#endregion