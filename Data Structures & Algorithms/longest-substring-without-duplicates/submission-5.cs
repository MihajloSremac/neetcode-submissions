public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int l = 0;
        int r = 0;

        int res = 0;
        while(r < s.Length){
            if(!set.Contains(s[r])){
                set.Add(s[r]);
                r++;
                res = Math.Max(res, r-l);
            }
            else{
                while(set.Contains(s[r])){
                    set.Remove(s[l]);
                    l++;
                }
            }
        }

        return res;
    }
}
