public class Solution {
    public int CharacterReplacement(string s, int k) {
        HashSet<char> set = new HashSet<char>(s);

        int res = 0;
        foreach(var letter in set){
            int l = 0;
            int r = 0;
            
            int count = 0;
            while(r < s.Length){
                if(s[r] != letter)
                    count++;
                
                if(count <= k){
                    r++;
                    res = Math.Max(res, r-l);
                }
                else{
                    while(count > k){
                        if(s[l] != letter){
                            count--;
                        }
                        l++;
                    }
                    r++;
                }
            }
        }
        return res;

    }
}
