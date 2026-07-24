public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> hashNums = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            
            int target2 = target - nums[i];

            if(hashNums.ContainsKey(target2))
            {
                return [hashNums[target2], i];
            }

            hashNums.Add(nums[i], i);
        }

        return [0,0];
    }
}
