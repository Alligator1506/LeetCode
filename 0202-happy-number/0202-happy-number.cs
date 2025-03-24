public class Solution {
    public bool IsHappy(int n)
    {
        // Handle edge cases
        if (n <= 0) return false;
        if (n == 1) return true;

        HashSet<int> seen = new HashSet<int>();

        while (n != 1)
        {
            if (seen.Contains(n))
            {
                return false;
            }
            seen.Add(n);
            n = getNext(n);
        }

        return true;
    }

    private int getNext(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}