public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> numbers = new HashSet<int>();

        foreach(int num in nums){
            if(numbers.Contains(num))
                return true;
            else
                numbers.Add(num);
        }

        return false;
    }
}