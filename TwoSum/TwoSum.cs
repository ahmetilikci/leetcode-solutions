using System;
using System.Collections.Generic;

// LeetCode #1 - Two Sum
// Time: O(n) | Space: O(n)

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int c = 0; c < nums.Length; c++)
        {
            int currentNum = nums[c];
            int total = target - currentNum;
            if (seenNumbers.ContainsKey(total))
            {
                return new int[] { seenNumbers[total], c };
            }
            if (!seenNumbers.ContainsKey(currentNum))
            {
                seenNumbers.Add(currentNum, c);
            }
        }

        return Array.Empty<int>();
    }
}
