public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> hashNums = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++){
            if(hashNums.ContainsKey(target - numbers[i]))
                return [hashNums[target - numbers[i]]+1, i+1];
            
            hashNums.Add(numbers[i], i);
        }

        return [0,0];
    }
}
