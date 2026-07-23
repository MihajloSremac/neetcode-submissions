class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s) {

        if(s.length === 0) return 0;

        let maxSubstring = 1;
    
        let l = 0; 
        let r  = 1;

        let lettersMap = new Map();
        lettersMap.set(s[0],0);

        while(r<s.length){
            if(!lettersMap.has(s[r])){
                lettersMap.set(s[r], r);
            }
            else if(lettersMap.get(s[r]) >= l){ 
                l = lettersMap.get(s[r]) + 1;
            }
                lettersMap.set(s[r], r);
                maxSubstring = Math.max(maxSubstring, r-l+1);
                r++;
        }

        return maxSubstring;
    }
}
