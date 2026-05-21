using System;

// LeetCode #121 - Best Time to Buy and Sell Stock
// Time: O(n) | Space: O(1)

public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int profit = 0;
        
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] > minPrice)
            {
                profit = Math.Max(profit, prices[i] - minPrice);
            }
        }
        
        return profit;
    }
}
