public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0; 
        int r = 0;
        int count = 0;
        HashSet<char> set = new HashSet<char>();
        while(r < s.Length){

            if(!set.Contains(s[r])){
                set.Add(s[r]);
                r++;
                count = Math.Max(r-l, count);
            }
            else{
                while(set.Contains(s[r])){
                    set.Remove(s[l]);
                    l++;
                }               
            }
        }

        return count;
    }
}
