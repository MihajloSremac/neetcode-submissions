public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> hashNums = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            int num1 = target - nums[i];

            if(hashNums.ContainsKey(num1)){
                return [hashNums[num1], i];
            }

            hashNums.Add(nums[i], i);
        }

        return [0,0];
    }
}
