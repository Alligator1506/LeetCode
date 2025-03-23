public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        List<int> target = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            target.Insert(index[i], nums[i]);
        }
        return target.ToArray();
    }

    public int[] Decode(int[] encoded, int first)
    {
        int[] decoded = new int[encoded.Length + 1];
        decoded[0] = first;
        for (int i = 0; i < encoded.Length; i++)
        {
            decoded[i + 1] = encoded[i] ^ decoded[i];
        }
        return decoded;
    }

    public int[] Shuffle(int[] nums, int n)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < n; i++)
        {
            result[2 * i] = nums[i];
            result[2 * i + 1] = nums[n + i];
        }
        return result;
    }
}