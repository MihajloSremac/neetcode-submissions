class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums) {
        const res = [];
        for (let num = 0; num < nums.length; num++){
            let product = 1;
            for (let i = 0; i < nums.length; i++){
                if(i === num)
                    continue;

                product = product * nums[i];
            }
            res.push(product);
        }

        return res;
    }
}
