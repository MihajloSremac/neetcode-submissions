public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> p = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){

            if(p.ContainsKey(target-nums[i]))
                return [p[target-nums[i]], i];
                
            p.Add(nums[i], i);
        }
    return [0,0];
    }

}
