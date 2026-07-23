class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        let results = {}

        for(let str of strs){
                let sorted = str.split('').sort().join('');
                if(!results[sorted]){
                    results[sorted] = [];
                }
                results[sorted].push(str);
        }

        return Object.values(results);
    }
}
