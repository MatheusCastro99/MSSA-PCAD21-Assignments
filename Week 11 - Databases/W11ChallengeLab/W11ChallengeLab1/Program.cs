//Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
//We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
//You must solve this problem without using the library's sort function.

//Example 1:
//Input: nums = [2, 0, 2, 1, 1, 0]
//Output: [0, 0, 1, 1, 2, 2]

//Example 2:
//Input: nums = [2, 0, 1]
//Output: [0, 1, 2]

//Thoughts:
//Classic sorting problem.
//Since the colors / numbers are limited to 0, 1, and 2, we can use a three-pointer approach to sort the array in a single pass.
//We can maintain three pointers: one for the next position of 0, one for the next position of 1, and one for the next position of 2.
//We will iterate through the array and swap elements into their correct positions based on their values.

//We are basically tracking how far red and white pointers can move, while the blue pointer will move backward as we encounter 2s.
//This way, we can sort the array in a single pass with O(n) time complexity and O(1) space complexity.

int[] nums = { 2, 0, 2, 1, 1, 0 };
int[] nums2 = { 2, 0, 1 };

Console.WriteLine("Input: " + string.Join(", ", nums));
Console.WriteLine("Output: " + string.Join(", ", ArrangeFlag(nums)));

int[] ArrangeFlag(int[] nums)
{
    int red = 0; // Pointer for the next position of 0
    int white = 0; // Pointer for the current element
    int blue = nums.Length - 1; // Pointer for the next position of 2
    while (white <= blue)
    {
        if (nums[white] == 0)
        {
            // Swap nums[red] and nums[white]
            (nums[red], nums[white]) = (nums[white], nums[red]);
            red++;
            white++;
        }
        else if (nums[white] == 1)
        {
            white++;
        }
        else // nums[white] == 2
        {
            // Swap nums[white] and nums[blue]
            (nums[white], nums[blue]) = (nums[blue], nums[white]);
            blue--;
        }
    }
    return nums;
}