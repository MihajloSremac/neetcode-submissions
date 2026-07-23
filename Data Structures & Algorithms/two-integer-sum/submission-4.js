class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {

        let complements = new Map();
        
        complements.set(nums[0], 0);

        for(let i = 1; i < nums.length; i++){
            
            let complement = target-nums[i];

            if(complements.has(complement)){
                return [complements.get(complement), i];
            }
            else
                complements.set(nums[i], i);
        }


    }
}
