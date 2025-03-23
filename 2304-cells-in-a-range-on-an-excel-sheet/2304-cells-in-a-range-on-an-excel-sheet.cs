public class Solution {
    public IList<string> CellsInRange(string s)
    {
        List<string> strings = new List<string>();
        char start = s[0];
        char end = s[3];
        char startRow = s[1];
        char endRow = s[4];
        for (char c = start; c <= end; c++)
        {
            for (char r = startRow; r <= endRow; r++)
            {
                strings.Add($"{c}{r}");
            }
        }
        return strings;
    }
}