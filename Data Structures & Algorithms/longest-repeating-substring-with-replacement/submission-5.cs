public class Solution {
    public int CharacterReplacement(string s, int k) {
        HashSet<char> set =  new HashSet<char>(s);
        if(set.Count == 1) return s.Length;

        int res = 0;
        foreach(var entry in set){
            int count = 0;
            int r = 0;
            int l = 0;
            
            for(r = 0; r < s.Length; r++){
                if(s[r] != entry){
                    count++; 
                }

                if(count <= k)
                    res = Math.Max((r-l)+1, res);

                while(count > k && l < s.Length){
                    if(s[l] != entry)
                        count--;
                    l++;
                }
            }
        }
        return res;
    }
}
