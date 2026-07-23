public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashNums = new HashSet<int>();

        foreach(int num in nums){
            if(hashNums.Contains(num))
                return true;

            hashNums.Add(num);
        }

        return false;
    }
}