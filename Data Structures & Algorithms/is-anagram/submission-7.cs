public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> ss =  new Dictionary<char, int>();
        Dictionary<char, int> tt =  new Dictionary<char, int>();

        if(s.Length != t.Length)
            return false;

        for (int i = 0; i < s.Length; i++){
            ss[s[i]] = ss.GetValueOrDefault(s[i], 0) + 1;
            tt[t[i]] = tt.GetValueOrDefault(t[i], 0) + 1;
        }

        return ss.Count == tt.Count && !ss.Except(tt).Any();
    }
}
