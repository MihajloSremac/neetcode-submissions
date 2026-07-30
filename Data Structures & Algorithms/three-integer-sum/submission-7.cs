public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        List<List<int>> res = new List<List<int>>();
        for(int i = 0; i < nums.Length; i++){
            int j = i+1;
            int k = nums.Length - 1;
            int target = -nums[i];

            if(i>0 && nums[i] == nums[i-1]) continue;

            while(j < k){
                if(nums[k]+nums[j] == target && k != i && j != i){
                    res.Add([nums[k], nums[j], nums[i]]); 
                    j++;
                    k--;         
                    while (j < k && nums[j] == nums[j - 1]) j++;
              
                }
                else if(nums[k]+nums[j] > target)
                    k--;
                else
                    j++;
            }
        }
        return res;
    }
}
