class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let map = {}

        for (let i = 0; i < nums.length; i++){
            if (nums[i] in map)
                return true;

            map[nums[i]] = i;
        }

        return false;
    }
}
