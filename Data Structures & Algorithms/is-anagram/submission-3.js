class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {

        if(t.length != s.length)
            return false;

        let map = {}



        for (let i = 0; i < s.length; i++) {
            let char = s[i];
            
            if(s[i] in map){
                map[char]++;
            }
            else{
                map[char] = 1;
            }
        }

        for (let i = 0; i < t.length; i++) {

            let char = t[i];

            if(!map[char]){
                return false;               
            }
            
            map[char]--;
        }

        return true;
    }
}
