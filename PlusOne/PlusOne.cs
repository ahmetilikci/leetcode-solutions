using System;

// LeetCode #66 - Plus One
// Time: O(n) | Space: O(n)

public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        
        int[] newArray = new int[digits.Length + 1];
        newArray[0] = 1;
        return newArray;
    }
}
