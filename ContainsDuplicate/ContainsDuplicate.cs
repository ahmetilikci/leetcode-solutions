using System;
using System.Collections.Generic;

// LeetCode #217 - Contains Duplicate
// Time: O(n) | Space: O(n)

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> last = new HashSet<int>();
        for (int a = 0; a < nums.Length; a++)
        {
            if (last.Contains(nums[a]))
                return true;
            else
                last.Add(nums[a]);
        }
        return false;
    }
}
