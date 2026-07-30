public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length-1;

        int res = 0;
        while(i<j){
            int v = Math.Min(heights[i], heights[j]) * (j-i);
            res = Math.Max(v, res);

            if(heights[j] < heights[i])
                j--;
            else
                i++;
        }

        return res;
    }
}
