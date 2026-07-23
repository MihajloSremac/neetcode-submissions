class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums) {
        let zerocount = 0;
        let product = 1;
        for(let num of nums){
            if(num === 0){
                zerocount++;
            }
            else{
                product *= num;
            }
        }

        if(zerocount >= 2){
            return Array(nums.length).fill(0);
        }

        const res = [];
        for(let i = 0; i < nums.length; i++){      
            if(zerocount === 1){
                res.push(nums[i] === 0 ? product : 0);
            }
            else{
                res.push(product/nums[i]);
            }
        }

        return res;
        
    }
}
