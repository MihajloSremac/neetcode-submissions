public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> count1 = new Dictionary<char, int>();
        Dictionary<char, int> count2 = new Dictionary<char, int>();


        for(int i = 0; i < s.Length; i++){
            count1[s[i]] = count1.GetValueOrDefault(s[i], 0) + 1;
            count2[t[i]] = count2.GetValueOrDefault(t[i], 0) + 1;
        }

        return count1.Count == count2.Count && !count1.Except(count2).Any();
    }
}
