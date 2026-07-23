class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
       let sets = new Set(nums);

       if(sets.size < nums.length)
        return true;

       return false; 
    }
}
