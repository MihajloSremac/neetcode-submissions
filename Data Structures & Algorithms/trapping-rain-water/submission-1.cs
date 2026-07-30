public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;

        int lMax = 0;
        int rMax = 0;

        int res = 0;
       while (l < r) {
            // ONLY process the side that is currently shorter
            if (height[l] < height[r]) {
                if (height[l] >= lMax) {
                    lMax = height[l];
                } else {
                    res += lMax - height[l];
                }
                l++; // Only move left
            } else {
                if (height[r] >= rMax) {
                    rMax = height[r];
                } else {
                    res += rMax - height[r];
                }
                r--; // Only move right
            }
        }

        return res;
    }
}
