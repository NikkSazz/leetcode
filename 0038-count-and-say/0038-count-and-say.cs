public class Solution {
    public string CountAndSay(int n) {
        if(n == 1) {
            return "1";
        }

        string say = CountAndSay(n - 1);

        List<string> parts = new List<string>();
        string current = "";
        char curChar = say[0];

        foreach (char c in say ) {
            if(c == curChar) {
                current += c;
            } else {
                parts.Add(current);
                curChar = c;
                current = c.ToString();
            }

        }
        parts.Add(current);

        string output = "";
        foreach(string s in parts) {
            // Console.WriteLine(s+" "+s.Length+" "+s[0]);
            output += s.Length.ToString() + s[0].ToString();
            // Console.WriteLine(s + "\t" + output);
        }
        return output;
    }
}