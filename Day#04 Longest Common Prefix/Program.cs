/*
    Problem: Longest Common Prefix
    ---------------------------------
    Write a function to find the longest common prefix string 
    amongst an array of strings. 

    If there is no common prefix, return an empty string "".

    Example 1:
        Input:  ["flower","flow","flight"]
        Output: "fl"

    Example 2:
        Input:  ["dog","racecar","car"]
        Output: ""

    ---------------------------------------------------------------
    Algorithm 
    ---------------------------------------------------------------
    1. Take the first string as reference.
    2. Iterate through each character of the first string.
    3. For each character position (i):
        - Compare that character with the same index in all other strings.
        - If mismatch OR index out of range → return prefix up to i.
    4. If loop finishes, the whole first string is the common prefix.


    ---------------------------------------------------------------

*/

using System;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // Edge case: empty array
        if (strs == null || strs.Length == 0)
            return "";

        // Loop through characters of the first string
        for (int i = 0; i < strs[0].Length; i++) {
            char c = strs[0][i]; // current character from first string
            
            // Compare this character with all other strings
            for (int j = 1; j < strs.Length; j++) {
                // If index is out of range OR mismatch found → return prefix till now
                if (i >= strs[j].Length || strs[j][i] != c) {
                    return strs[0].Substring(0, i);
                }
            }
        }

        // If loop finishes, the whole first string is the prefix
        return strs[0];
    }
}

public class Program {
    public static void Main() {
        Solution sol = new Solution();

        Console.WriteLine(sol.LongestCommonPrefix(new string[] {"flower","flow","flight"})); // "fl"
        Console.WriteLine(sol.LongestCommonPrefix(new string[] {"dog","racecar","car"}));   // ""
        Console.WriteLine(sol.LongestCommonPrefix(new string[] {"interspecies","interstellar","interstate"})); // "inters"
        Console.WriteLine(sol.LongestCommonPrefix(new string[] {"a"}));                     // "a"
        Console.WriteLine(sol.LongestCommonPrefix(new string[] {"", "b"}));                // ""
    }
}
