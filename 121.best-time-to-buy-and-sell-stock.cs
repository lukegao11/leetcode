/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int minP = int.MaxValue;
        int MaxP = 0;
        for(int i = 0; i < prices.Length; i++){
            if (prices[i] < minP){
                minP = prices[i];
            } else {
                if (prices[i] - minP > MaxP)
                    MaxP = prices[i] - minP;
            }
        }
        return MaxP;
    }
}
// @lc code=end

