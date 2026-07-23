class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {

        if(s.length !== t.length)
            return false;

        let letters = new Map();

        for(let char of s){
            letters.set(char, (letters.get(char) || 0) + 1);
        }

        for(let char of t){
            if(!letters.has(char))
                return false;
            
            let newCount = letters.get(char) - 1;
            if(newCount < 0)
                return false;
            
            letters.set(char, newCount);
        }

        return true;
    }
}
