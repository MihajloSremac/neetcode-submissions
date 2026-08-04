public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;

        int lm = height[l];
        int rm = height[r];

        int res = 0;
        while (l < r) {
            if (lm < rm) {
                l++;
                if (lm < height[l])
                    lm = height[l];
                else
                    res += lm - height[l];

            } else {
                r--;
                if (rm < height[r])
                    rm = height[r];
                else
                    res += rm - height[r];
            }
        }

        return res;
    }
}
