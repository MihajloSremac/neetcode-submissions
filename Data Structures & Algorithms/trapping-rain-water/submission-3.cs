public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;

        int leftMax = height[l];
        int rightMax = height[r];

        int res = 0;
        while(l < r){
            if(leftMax < rightMax){
                l++;
                if(height[l] > leftMax){
                    leftMax = height[l];
                }
                else{
                    res += leftMax - height[l];
                }
            }
            else{
                r--;
                if(height[r] > rightMax){
                    rightMax = height[r];
                }
                else{
                    res += rightMax - height[r];
                }
            }
        }

        return res;
    }
}
