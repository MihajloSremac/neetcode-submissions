public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> numbers =  new HashSet<int>(nums);

        return numbers.Count < nums.Length;
    }
}