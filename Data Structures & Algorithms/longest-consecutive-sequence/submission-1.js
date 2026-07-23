class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums) {
        let set = new Set(nums);
        let res = 0;
        for(let num of nums){
            if(!set.has(num-1)){
                let length = 1;
                while(set.has(num+length)){
                    length++;
                }
                res = length>res ? length : res;
            }
        }

        return res;
    }
}
