//You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
//Merge nums1 and nums2 into a single array sorted in non-decreasing order.
//The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
//To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

//Example 1:
//Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
//Output: [1,2,2,3,5,6]
//Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
//The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

//Example 3:
//Input: nums1 = [0], m = 0, nums2 = [1], n = 1
//Output: [1]
//Explanation: The arrays we are merging are [] and [1].
//The result of the merge is [1].
//Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    // Set pointers for nums1, nums2, and the final merged array
    // It is said that nums1 and 2 have the length of m and n, so m-1 and n-1 represent the last element of those arrays
    int p1 = m - 1;
    int p2 = n - 1;
    int p = m + n - 1;

    // Merge in reverse order
    while (p1 >= 0 && p2 >= 0)
    {
        // if-else checks which element will be merged from the two arrays
        if (nums1[p1] > nums2[p2])
        {
            nums1[p] = nums1[p1];
            p1--;
        }
        else
        {
            nums1[p] = nums2[p2];
            p2--;
        }
        p--;
    }

    // If nums2 still has elements, copy them over
    // If nums1 has elements left, they must already be in the correct place
    while (p2 >= 0)
    {
        nums1[p] = nums2[p2];
        p2--;
        p--;
    }
}