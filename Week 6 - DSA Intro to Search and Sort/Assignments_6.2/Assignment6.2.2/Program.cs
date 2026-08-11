//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

//Constraints:
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
//You must write an algorithm that runs in O(n) time
//Must do it without using the division operation.

//Thoughts:
//Maybe can be achieved with a LINQ Where operation. LINQ approach actually gets a O(n^2)
//During iteration, I could split array in two: right and left of i
//That would create an array for each for loop iteration.
//I could make an accumulator variable holding the values of the product of elements right and left of i
     // [1, 2, 3, 4] product: 24
     // Left accumulator: [1, (1*1) 1, (1*2) 2, (2*3) 6]
     // iterate backwards through accumulator array completing with the right products
     // Right accumulator: [x, x, x, (6*1) 6] -> [x, x, (2*nums[3]) 8, 6] -> [x, (1 * (nums[2] * nums[3])) 12, 8, 6] -> [1 * (2*3*4) 24, 12, 8, 6]

int[] nums = [1, 2, 3, 4];

Console.WriteLine(string.Join(", ", nums));

//GetProductExceptSelfLINQ(nums);
nums = GetProductExceptSelfTwoPointer(nums);

Console.WriteLine(string.Join(", ", nums));

void GetProductExceptSelfLINQ(int[] nums)
{
    int[] operationalArray = (int[])nums.Clone();

    for (int i = 0; i < nums.Length; i++)
    {
        operationalArray[i] = nums
            .Where((val, idx) => idx != i) //List all numbers of array but self (idx != i)
            .Aggregate(1, (a, b) => a * b); //Return the product of elements of that list
    }

    nums = (int[])operationalArray.Clone();
}

int[] GetProductExceptSelfTwoPointer(int[] nums)
{
    int[] finalArray = new int[nums.Length];
    finalArray[0] = 1; //First number has to be 1, or else the end result will always be zero

    //left accumulator
    for (int i = 1; i < nums.Length; i++) //iterates forward accumulating the product of numbers to the left of i
    {                                     //Starts at i=1 due to i-1 reference (getting elements to the left of self)
        finalArray[i] = finalArray[i - 1] * nums[i - 1];
    }

    //right accumulator
    int accumulatedRight = 1;
    for (int j = nums.Length-1; j >=0 ; j--) //iterates backwards accumuating the product of numbers to the right of i
    {
        finalArray[j] *= accumulatedRight;
        accumulatedRight *= nums[j]; //adjusts accumulatedRight with nums array 
    }

    return finalArray;
}