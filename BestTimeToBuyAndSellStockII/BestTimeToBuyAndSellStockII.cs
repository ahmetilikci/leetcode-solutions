using System;

// LeetCode #122 - Best Time to Buy and Sell Stock II
// Time: O(n) | Space: O(1)

public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        
        for (int i = 1; i < prices.Length; i++)
        {
             if (prices[i] > prices[i-1])
            {
                profit += (prices[i] - prices[i-1]);
            }
        }
        
        return profit;
    }
}
