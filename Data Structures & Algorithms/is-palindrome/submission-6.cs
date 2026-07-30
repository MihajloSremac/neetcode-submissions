public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 0)
            return true;
        
        int l = 0;
        int r = s.Length - 1;

        while(l<r){
            while (l < r && 
                !((s[l] >= 'a' && s[l] <= 'z') || 
                (s[l] >= 'A' && s[l] <= 'Z') || 
                (s[l] >= '0' && s[l] <= '9')))
                l++;
            while (l < r && 
                !((s[r] >= 'a' && s[r] <= 'z') 
                || (s[r] >= 'A' && s[r] <= 'Z') 
                || (s[r] >= '0' && s[r] <= '9')))
                r--;

            if(char.ToLower(s[r]) != char.ToLower(s[l]))
                return false;
            l++;
            r--;
        }

        return true;
    }
}
