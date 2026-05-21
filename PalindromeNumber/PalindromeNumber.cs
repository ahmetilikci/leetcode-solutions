// LeetCode #9 - Palindrome Number
// https://leetcode.com/problems/palindrome-number/
// Time: O(log n) | Space: O(1)

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        if (x == 0)
            return true;

        long reversed = 0;
        int length = x.ToString().Length;
        int halfway = length / 2;

        for (int i = 0; i < halfway; i++)
        {
            reversed = (reversed * 10) + (x % 10);
            x /= 10;
        }

        if (length % 2 != 0) x /= 10;

        return x == reversed;
    }
}
