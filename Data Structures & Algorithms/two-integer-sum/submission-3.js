class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        
        let map = new Map()

        for(let i = 0; i < nums.length; i++){
            let num = nums[i];

            let potrebanbroj = target - nums[i]

            if(map.has(potrebanbroj)){
                return [map.get(potrebanbroj),i]
            }

            map.set(num, i);
        }

        return false;
    }
}
