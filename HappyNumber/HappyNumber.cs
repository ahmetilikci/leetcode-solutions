using System;
using System.Collections.Generic;

// LeetCode #202 - Happy Number (Easy)
// Approach: Hash Set with Modulo Math
// Time: O(log n)
// Space: O(log n)

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            int sum = 0;
            
            while (n > 0)
            {
                int digit = n % 10;
                sum += (digit * digit);
                n /= 10;
            }
            
            n = sum;
        }

        return n == 1;
    }
}
