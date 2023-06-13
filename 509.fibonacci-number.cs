/*
 * @lc app=leetcode id=509 lang=csharp
 *
 * [509] Fibonacci Number
 */

// @lc code=start
public class Solution {
    public int Fib(int n) {
        if(n <= 1) return n;
        int prevprev = 0;
        int prev = 1;
        int cur = 0;
        for(int i = 2 ; i <= n ; i++){
            cur = prev + prevprev;
            int temp = prev;
            prev = cur;
            prevprev = temp;
        }
        return cur;

    }
}
// @lc code=end

