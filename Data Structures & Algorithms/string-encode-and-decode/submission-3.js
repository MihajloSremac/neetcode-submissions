class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {
        
       let res = "";
        for(let s of strs){
            res += s.length + "#" + s;
        }

        return res;
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {

        let l = 0;
        const res = [];
        for (let r = 0; r<str.length; r++){
            if(str[r] != "#")
                continue;

            let num = parseInt(str.slice(l,r));
            res.push(str.slice(r+1, r+num+1));

            l = r+num+1;
            r += num;
        }

        return res;
    }
}
