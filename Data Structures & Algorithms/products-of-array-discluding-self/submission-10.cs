public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] pref = new int[nums.Length];
        int[] suff = new int[nums.Length];
        int[] res = new int[nums.Length];

        pref[0] = 1;
        suff[nums.Length - 1] = 1;

        for(int i = 1; i < pref.Length; i++){
            pref[i] = pref[i-1] * nums[i-1];
        }

        for(int i = suff.Length-2; i >= 0; i--){
            suff[i] = suff[i+1] * nums[i+1];
        }

        for(int i = 0; i < res.Length; i++){
            res[i] = suff[i] * pref[i];
        }

        return res;
    }
}
