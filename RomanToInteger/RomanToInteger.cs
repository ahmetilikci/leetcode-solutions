// LeetCode #13 - Roman to Integer
// https://leetcode.com/problems/roman-to-integer/
// Time: O(n) | Space: O(1)

public class Solution
{
    public int RomanToInt(string s)
    {
        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = GetValue(s[i]);

            if (i + 1 < s.Length)
            {
                int next = GetValue(s[i + 1]);

                if (current < next)
                {
                    total += next - current;
                    i++;
                }
                else
                {
                    total += current;
                }
            }
            else
            {
                total += current;
            }
        }

        return total;
    }

    private int GetValue(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}
