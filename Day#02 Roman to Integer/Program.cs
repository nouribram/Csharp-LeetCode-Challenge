/*
# Roman to Integer (LeetCode) — C# Solution

## Short details
Convert a Roman numeral string into its integer value.
Input is guaranteed valid and in range [1, 3999].

## Problem
Given a Roman numeral string `s`, return its integer.
Examples:
- "III" → 3
- "LVIII" → 58
- "MCMXCIV" → 1994

## Solution (step by step)
1. Read the string **from right to left**.
2. Keep two variables: `total = 0`, `prev = 0`.
3. For each character:
   - Convert Roman symbol to integer (I=1, V=5, X=10, L=50, C=100, D=500, M=1000).
   - If `value < prev` → subtract it from `total`.
   - Else → add it to `total`.
   - Update `prev = value`.
4. After loop ends, return `total`.

This works because subtractive cases (like IV=4) are automatically handled 
by the `value < prev` check.

## Code
*/

public class Solution
{
    public int RomanToInt(string s)
    {
        int total = 0, prev = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = s[i] switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };

            total += (value < prev) ? -value : value;
            prev = value;
        }

        return total;
    }
}
