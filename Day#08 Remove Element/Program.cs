/*
  C# Algorithm Tutorial — Remove Element (LeetCode #27)
  Problem:
  Given an integer array 'nums' and an integer 'val',
  remove all occurrences of 'val' in-place and return the count of elements not equal to 'val'.
 
 * Example:
 * Input:  nums = [3,2,2,3], val = 3
 * Output: 2, nums = [2,2,_,_]
 */

using System;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        // Pointer 'k' keeps track of the position to place the next valid element
        int k = 0;

        // Loop through all elements in the array
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current element is NOT equal to 'val', keep it
            if (nums[i] != val)
            {
                nums[k] = nums[i]; // Move valid element forward
                k++;               // Increment count of valid elements
            }
            // If nums[i] == val, we simply skip it (do not copy)
        }


        return k; // Return the count of elements not equal to val
    }

    // Example usage
    public static void Main()
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;

        Solution solution = new Solution();
        int k = solution.RemoveElement(nums, val);

        Console.WriteLine($"Number of valid elements: {k}");
        Console.Write("Modified array: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}
