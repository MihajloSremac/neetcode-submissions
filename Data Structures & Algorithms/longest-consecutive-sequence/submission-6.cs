public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hashNums = new HashSet<int>(nums);

        int res = 0;
        foreach(int num in nums){
            if(!hashNums.Contains(num-1)){
                int j = 1;
                while(hashNums.Contains(num+j))
                    j++;

                res = Math.Max(res, j);
            }
        } 

        return res;
    }
}
