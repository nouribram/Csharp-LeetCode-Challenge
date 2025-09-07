/* Day #01 - Two Sum Problem

## Problem
Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to target.

## Example
Input: nums = [2,7,11,15], target = 9  
Output: [0,1]  

## Solution (C#)
*/


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }
        return new int[] { -1, -1 };
    }
}
