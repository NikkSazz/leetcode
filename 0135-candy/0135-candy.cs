public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] children = new int[n];
        for(int i = 0; i < n; i++) {
            children[i] = 1;
        }

        while(!PassesRequirements(children, ratings)) {
            // left to right
            for(int i = 1; i < n; i++) {
                if(ratings[i] > ratings[i - 1]) {
                    if(children[i] <= children[i - 1])
                        children[i]++;
                }
            }
            // right to left
            for(int i = n - 2; i >= 0; i--) {
                if(ratings[i] > ratings[i + 1]) {
                    if(children[i] <= children[i + 1])
                        children[i]++;
                }
            }

        }

        int candies = 0;
        foreach(var child in children) {
            candies += child;
        }
        return candies;
    }

   private bool PassesRequirements(int[] children, int[] ratings) {
        for (int i = 1; i < ratings.Length; i++) {
            if (ratings[i] > ratings[i - 1] && children[i] <= children[i - 1]) {
                return false;
            }
            if (ratings[i] < ratings[i - 1] && children[i] >= children[i - 1]) {
                return false;
            }
        }
       return true;
    }
}