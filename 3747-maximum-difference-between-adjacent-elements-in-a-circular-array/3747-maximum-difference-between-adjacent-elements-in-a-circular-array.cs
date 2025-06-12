public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int max = Math.Abs(nums[0] - nums[nums.Length - 1]);
        for(int i = 1; i < nums.Length; i++) {
            int cmp = Math.Abs(nums[i] - nums[i - 1]);
            max = cmp > max ? cmp : max;
        }
        return max;
    }
}