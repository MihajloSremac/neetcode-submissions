class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        
        let map = {}

        for(let i = 0; i < nums.length; i++){
            let num = nums[i];

            if(num in map){
                return [map[num],i]
            }

            let potrebanbroj = target - nums[i]

            if(potrebanbroj in map){
                return [map[potrebanbroj],i]
            }

            map[num] = i;
        }

        return false;
    }
}
