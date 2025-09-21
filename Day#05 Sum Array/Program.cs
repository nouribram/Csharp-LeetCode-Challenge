/*
 Problem: Sum Arrays
 -------------------
 Given an array of numbers, return the sum of all elements.
 If the array is null or empty, return 0.

 Example:
 SumArray(new double[] {1, 2, 8});   // 11
 SumArray(new double[] {});          // 0
 SumArray(null);                     // 0

 Approach (LINQ version):
 ------------------------
 1. Check if the array is null or empty.
    - If yes, return 0.
 2. Otherwise, use LINQ's Sum() method to calculate the total directly.
 3. This gives a concise one-line solution.
*/

using System.Linq;

public static class Kata
{
    public static double SumArray(double[] numbers)
    {
        return (numbers == null || numbers.Length == 0) ? 0 : numbers.Sum();
    }
}
