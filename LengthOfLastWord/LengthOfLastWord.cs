// LeetCode #58 - Length of Last Word
// https://leetcode.com/problems/length-of-last-word/
// Time: O(n) | Space: O(1)

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int total = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                total++;
            }
            else if (total > 0)
            {
                break;
            }
        }

        return total;
    }
}