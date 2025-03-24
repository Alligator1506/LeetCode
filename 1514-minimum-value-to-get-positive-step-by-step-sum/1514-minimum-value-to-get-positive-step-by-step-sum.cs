public class Solution {
    public int MinStartValue(int[] nums)
    {
        int minSum = 0;
        int currentSum = 0;
        foreach (int num in nums)
        {
            currentSum += num;
            minSum = Math.Min(minSum, currentSum);
        }
        return 1 - minSum;
    }
}