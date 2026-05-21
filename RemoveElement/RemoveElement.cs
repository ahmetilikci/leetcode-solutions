// LeetCode #27 - Remove Element
// https://leetcode.com/problems/remove-element/
// Time: O(n) | Space: O(1)

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int writeIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }

        return writeIndex;
    }
}
