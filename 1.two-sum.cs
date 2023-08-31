/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        // for (int i = 0; i < nums.Length; i++ ){
        //     dict.Add(nums[i], i);
        // } cant handle duplicates if adding to the hashmap first (unlike java will preserve the last one)
        for (int j = 0; j < nums.Length; j++ ){
            int index = target - nums[j];
            if(dict.ContainsKey(index)){
                return new int[]{dict[index], j};
            }else dict[nums[j]] = j;
        }
        return null;
        
    }
}

// @lc code=end
