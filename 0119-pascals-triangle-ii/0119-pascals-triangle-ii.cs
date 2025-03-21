public class Solution {
    public IList<int> GetRow(int rowIndex)
    {
        IList<int> result = new List<int>();
        for (int i = 0; i <= rowIndex; i++) {
            result.Add(1);
            for (int j = i - 1; j > 0; j--) {
                result[j] = result[j] + result[j-1];
            }
        }
        return result;
    }
}