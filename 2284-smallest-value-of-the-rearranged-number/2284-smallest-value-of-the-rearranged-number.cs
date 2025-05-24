public class Solution {
    public long SmallestNumber(long num) {
        string str = new string(num.ToString().OrderBy(c => c).ToArray());
        Console.WriteLine(str);
        List<char> l = str.ToList();
        bool negative = l[0] == '-';

        if(negative) {
            l.RemoveAt(0);
            l.Reverse();
            l.Insert(0, '-');
        }
        else if(str.Contains('0')) {
            for(int i = negative ? 1 : 0; i < str.Length; i++ ) {
                if(l[i] == '0') continue;

                l[0] = l[i];
                l[i] = '0';
                break;
            }
        }
        return long.Parse(new string(l.ToArray()));
    }
}