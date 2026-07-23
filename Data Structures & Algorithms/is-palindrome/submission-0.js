class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */

    isLetterOrNumber(char){
        if(
            (char >= 'a' && char <= 'z') ||
            (char >= 'A' && char <= 'Z') ||
            (char >= '0' && char <= '9')
        ) return true;

        return false;
    }

    isPalindrome(s) {
        let l = 0;
        let r = s.length - 1;

        while (l<r){
            while(l < r && !this.isLetterOrNumber(s[l]))
                l++;
            while(l < r && !this.isLetterOrNumber(s[r]))
                r--;
            
            if(s[l].toLowerCase() !== s[r].toLowerCase())
                return false;

            l++;
            r--;
        }
        return true;
    }
}
