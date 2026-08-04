public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        int res = 0;
        foreach(int num in nums){
            int count = 1;
            if(!set.Contains(num-1)){
                while(set.Contains(num+count))
                    count++;
                res = Math.Max(res, count);
            }
        }

        return res;
    }
}
