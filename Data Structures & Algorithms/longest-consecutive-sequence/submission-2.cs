public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        int res = 0;
        foreach(int num in nums){
            if(!set.Contains(num-1)){
                int temp = 1;
                while(set.Contains(num + temp)){
                    temp++;
                }

                res = Math.Max(res, temp);
            }
        }

        return res;
    }
}
