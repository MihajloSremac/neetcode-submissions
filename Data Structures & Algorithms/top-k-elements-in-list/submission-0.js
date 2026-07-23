class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {
        const res = [];
        const map = {};
        for (let num of nums){
            if(!map[num])
                map[num] = 1;
            else
                map[num]++;
        }

        const freq = Array.from({length: nums.length + 1}, () => []);

        for (const m in map){
            freq[map[m]].push(m);
        }

        for(let i = freq.length - 1; i>=0; i--){
            for (let j = 0; j < freq[i].length; j++){
                res.push(freq[i][j]);
                if(res.length === k)
                    return res;
            }
        }
    }
}
