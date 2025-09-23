// Problem: Valid Parentheses 
// -------------------------------------------------------
// Task:
//   Given a string containing just the characters '(', ')', '{', '}', '[' and ']',
//   determine if the input string is valid.
//
// A string is valid if:
//   1. Open brackets are closed by the same type of brackets.
//   2. Open brackets are closed in the correct order.
//
// Examples:
//   Input: "()"        ➞ true
//   Input: "()[]{}"    ➞ true
//   Input: "(]"        ➞ false
//   Input: "([)]"      ➞ false
//   Input: "{[]}"      ➞ true
//
// Approach:
//   - Use a Stack to keep track of opening brackets.
//   - When we encounter a closing bracket, check if it matches the top of the stack.
//   - If it does, pop it; otherwise, the string is invalid.
//   - At the end, the stack must be empty for the string to be valid.
//

using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            // If it's an opening bracket, push it to the stack
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                // If stack is empty, there's no opening bracket to match
                if (stack.Count == 0) return false;

                char top = stack.Pop();

                // Check if the current closing bracket matches the top
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        // String is valid only if no unmatched opening brackets remain
        return stack.Count == 0;
    }
}

// --------- Testing the function ---------
public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        
        Console.WriteLine(sol.IsValid("()"));       // ➞ true
        Console.WriteLine(sol.IsValid("()[]{}"));   // ➞ true
        Console.WriteLine(sol.IsValid("(]"));       // ➞ false
        Console.WriteLine(sol.IsValid("([)]"));     // ➞ false
        Console.WriteLine(sol.IsValid("{[]}"));     // ➞ true
    }
}
