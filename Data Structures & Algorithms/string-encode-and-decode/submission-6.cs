public class Solution {
    public string Encode(IList<string> strs) {
        string encode = "";

        foreach (string str in strs) 
            encode = encode + str.Length + '#' + str;

        return encode;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();

        int i = 0;
        while (i < s.Length) {
            int j = i;

            while (s[j] != '#') {
                j++;
            }  // example 4#miha3#mig

            // duzina za substringovanje
            int length = int.Parse(s.Substring(i, j - i));

            res.Add(s.Substring(j + 1, length));

            i = j + 1 + length;
        }

        return res;
    }
}
