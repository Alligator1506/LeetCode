public class Solution {
    public int FindLucky(int[] arr)
    {
        int[] numbers = new int[501];
        foreach (int j in arr)
        {
            numbers[j]++;
        }

        for (int i = 500; i > 0; i--)
        {
            if (i == numbers[i])
            {
                return i;
            }
        }
        return -1;
        // Dictionary<int, int> frequency = new Dictionary<int, int>();
        // foreach (int num in arr)
        // {
        //     if (frequency.ContainsKey(num))
        //     {
        //         frequency[num]++;
        //     }
        //     else
        //     {
        //         frequency[num] = 1;
        //     }
        // }
        // int luckyNumber = -1;
        // foreach (KeyValuePair<int, int> pair in frequency)
        // {
        //     if (pair.Key == pair.Value && pair.Key > luckyNumber)
        //     {
        //         luckyNumber = pair.Key;
        //     }
        // }
        // return luckyNumber;
    }
}