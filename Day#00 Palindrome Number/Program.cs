/* Palindrome Number — C# Solution
_______________________________________

## Problem
Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

### Examples
- `121` → true
- `-121` → false
- `10` → false


## Algorithm
1. Handle edge cases:
   - Negative numbers → not palindrome.
   - Multiples of 10 (except 0) → not palindrome.
2. Reverse digits until reversed half >= remaining `x`.
3. Compare `x == reversedHalf` (even digits) or `x == reversedHalf / 10` (odd digits).

*/
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reversedHalf = 0;
        while (x > reversedHalf) {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        return x == reversedHalf || x == reversedHalf / 10;
    }
}
