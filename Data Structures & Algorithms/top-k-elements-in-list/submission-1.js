class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {

        let count = new Map();

        for(let n of nums){
            count.set(n, (count.get(n) || 0) + 1);
        }

        let freq = Array.from({length: nums.length+1}, () => []);

        for(let [num,cnt] of count){
            freq[cnt].push(num);
        }

        let res = [];
        for(let i = nums.length; i>0; i--){
            for(let n of freq[i]){
                res.push(n);
                if(res.length === k) return res;
            }
        }
    }
}
