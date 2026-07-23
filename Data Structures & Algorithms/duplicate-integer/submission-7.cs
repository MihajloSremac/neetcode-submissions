public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        foreach(int num in nums){
            if(numbers.ContainsKey(num))
                return true;
            else
                numbers.Add(num, num);
        }

        return false;
    }
}