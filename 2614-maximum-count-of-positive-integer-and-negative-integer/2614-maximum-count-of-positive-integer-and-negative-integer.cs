public class Solution {
    public int MaximumCount(int[] nums) {
        int positive = 0;
        int negative = 0;

        foreach(var n in nums) {
            if (n > 0) positive++;
            else if (n < 0) negative++;
        }

        return positive > negative ? positive : negative;
    }
}