public class Solution {
    public int MaxDifference(string s) {
        var maxOdd = 0;
        var minEven = 100_000;

        Dictionary<char, int> f = new Dictionary<char, int>();

        foreach(char c in s) {
            if(f.ContainsKey(c)) {
                f[c]++;
            }
            else {
                f[c] = 1;
            }
        }

        foreach(var i in f) {
            if(i.Value % 2 == 0) {
                minEven = Math.Min(i.Value, minEven);
            }
            else {
                maxOdd = Math.Max(i.Value, maxOdd);
            }
        }

        return maxOdd - minEven;
    }
}