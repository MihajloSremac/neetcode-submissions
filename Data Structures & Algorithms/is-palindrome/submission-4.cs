public class Solution {
    public bool IsPalindrome(string s) {
        
        int i = 0;
        int j = s.Length - 1;
        while(i < j){
            while(i < j && !((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z')  || (s[i] >= '0' && s[i] <= '9'))){
                i++;
            }

            while(i < j && !((s[j] >= 'A' && s[j] <= 'Z') || (s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9'))){
                j--;
            }

            if(char.ToLower(s[j]) != char.ToLower(s[i]))
                return false;

            i++;
            j--;
        }

        return true;
    }
}
