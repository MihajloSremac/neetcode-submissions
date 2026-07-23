class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {

        let mapagrams = new Map();

        for(let str of strs){
            let sortedStr = str.split("").sort().join("");

            if(mapagrams.has(sortedStr))
                mapagrams.get(sortedStr).push(str);

            else
                mapagrams.set(sortedStr, [str]);
        }

        return Array.from(mapagrams.values());
    }
}
