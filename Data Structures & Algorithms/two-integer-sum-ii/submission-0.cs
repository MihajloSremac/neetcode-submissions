public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> hash = new Dictionary<int, int>();

        for(int i = 0; i < numbers.Length; i++){
            int t = target - numbers[i];

            if(hash.ContainsKey(t) && t != numbers[i])
                return [hash[t]+1, i+1];

            hash.Add(numbers[i], i);
        }

        return [0,0];
    }
}
