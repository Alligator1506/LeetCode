public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hashSet.Contains(nums[i]))
            {
                return true;
            }
            hashSet.Add(nums[i]);

            if (hashSet.Count > k)
            {
                hashSet.Remove(nums[i - k]);
            }
        }
        return false;
    }
}