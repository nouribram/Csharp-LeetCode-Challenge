/*
 Problem: Sum Arrays
 -------------------
 Given an array of numbers, return the sum of all elements.
 If the array is null or empty, return 0.

 Example:
 SumArray(new double[] {1, 2, 7});   // 10
 SumArray(new double[] {});          // 0
 SumArray(null);                     // 0

 Approach:
 ---------
 1. Check if the array is null or empty → return 0.
 2. Create a variable (sum) to hold the total.
 3. Loop through each element of the array.
 4. Add each element to sum.
 5. Return the total after the loop.
*/

public static class Kata
{
    public static double SumArray(double[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}
