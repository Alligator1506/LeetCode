public class Solution {
    public bool IsValid(string s) {
        // Stack<char> stack = new Stack<char>();

        // Dictionary<char, char> match = new Dictionary<char, char>
        // {
        //     { ')', '(' },
        //     { ']', '[' },
        //     { '}', '{' }
        // };

        // foreach (char ch in s) {
        //     if (ch == '(' || ch == '[' || ch == '{') {
        //         stack.Push(ch);
        //     } else if (match.ContainsKey(ch)){
        //         if (stack.Count == 0 || match[ch] != stack.Pop()) {
        //             return false;
        //         }
        //     }
        // }
        // return stack.Count == 0;
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> match = new Dictionary<char, char>
        {   
            // {'(',')'},
            // {'[',']'},
            // {'{','}'},
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char ch in s)
        {
            if (match.ContainsValue(ch))
            {
                stack.Push(ch);
            }
            else if (match.ContainsKey(ch)) 
            {
                if (stack.Count == 0 || match[ch] != stack.Pop())
                {
                    return false;
                }  
            }
        }
        return stack.Count == 0;
    }
}
