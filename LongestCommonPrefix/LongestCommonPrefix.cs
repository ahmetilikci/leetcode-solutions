// LeetCode #14 - Longest Common Prefix
// https://leetcode.com/problems/longest-common-prefix/
// Time: O(n * m) | Space: O(1)

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        for (int i = 0; i < strs[0].Length; i++)
        {
            char current = strs[0][i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != current)
                    return strs[0].Substring(0, i);
            }
        }

        return strs[0];
    }
}
