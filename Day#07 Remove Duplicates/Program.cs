// Problem: Remove Duplicates from Sorted Array 
// --------------------------------------------------
// Explanation:
// - The array is sorted, so duplicates are grouped together.
// - use the "two-pointer" technique to solve this in O(n) time.
// - One pointer (writeIndex) keeps track of the position where
//   the next unique element should be placed.
// - The other pointer (i) scans through the array.
// - Whenever we find a new unique element, we move it to writeIndex
//   and increment writeIndex.
// - Finally, writeIndex represents the length of the array without duplicates.
// --------------------------------------------------


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        
        int writeIndex = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }
        return writeIndex;
    }
}

