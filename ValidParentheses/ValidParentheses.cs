using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> checkParentheses = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        Stack<char> stack = new Stack<char>();

        for (int a = 0; a < s.Length; a++)
        {
            if (checkParentheses.ContainsKey(s[a]))
            {
                stack.Push(s[a]);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char lastOpened = stack.Pop();
                if (checkParentheses[lastOpened] != s[a])
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
