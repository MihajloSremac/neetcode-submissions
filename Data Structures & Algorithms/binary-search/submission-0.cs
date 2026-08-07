public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0; int r = nums.Length - 1;

        return BinarySearch(l,r,nums,target);
    }

    public int BinarySearch(int l, int r, int[] nums, int target){
        if(l > r) return -1;
        int mid = l + ((r-l)/2);
        
        if(nums[mid] == target) return mid;

        int res = nums[mid] > target 
            ? BinarySearch(l, mid - 1, nums, target) : BinarySearch(mid + 1, r, nums, target);

        return res;
    }
}
