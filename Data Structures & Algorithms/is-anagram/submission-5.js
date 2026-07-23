class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {

        if(s.length !== t.length)
            return false;

        let letters = {}

        for(let char of s){
            if(char in letters){
                letters[char]++;
            }
            else{
                letters[char] = 1;
            }
        }

        for(let char of t){
            if(char in letters){
                letters[char]--;
                if(letters[char] < 0)
                    return false;
            }
            else{
                return false;
            }
        }

        return true;
    }
}
