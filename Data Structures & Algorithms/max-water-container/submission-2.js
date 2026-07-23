class Solution {
    /**
     * @param {number[]} heights
     * @return {number}
     */
    maxArea(heights) {

        let max = 0;

        let l = 0;
        let r = heights.length-1;

        while(l<r){
            let distance = r-l;
            
            let area = heights[l] <= heights[r] ? heights[l] * distance : heights[r] * distance;
            max = Math.max(max, area)

            if(heights[l]>heights[r]) r--;
            else if (heights[l]<heights[r]) l++;
            else {
                r--;
                l++;
            }
        }

        return max;
    }
}
