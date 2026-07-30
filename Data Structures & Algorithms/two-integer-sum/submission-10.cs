public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashNums = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(hashNums.ContainsKey(target-nums[i]))
                return [hashNums[target-nums[i]], i];

            hashNums.Add(nums[i], i);
        }

        return [0,0];
    }
}
