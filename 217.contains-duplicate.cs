/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> l = nums.ToList();
        for (int i = 0; i < l.Count; i++){
            int tmp = l[i];
            l.RemoveAt(i);
            if (l.Contains(tmp)){
                l.Add(tmp);
                return true;
            } else {
                l.Add(tmp);
            }
        }
        return false;
    }
}
// @lc code=end

