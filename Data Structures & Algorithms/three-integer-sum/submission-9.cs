public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        List<List<int>> res = new List<List<int>>();

        for(int i = 0; i < nums.Length; i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int target = -nums[i];
            
            int l = i + 1;
            int r = nums.Length - 1;

            while(l < r){
                if(nums[l] + nums [r] > target){
                    r--;
                }
                else if(nums[l] + nums [r] < target){
                    l++;
                }
                else{
                    res.Add([nums[l], nums[r], nums[i]]);
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) l++;
                    while (l < r && nums[r] == nums[r + 1]) r--;
                }
                    
            }
        }

        return res;
    }
}
