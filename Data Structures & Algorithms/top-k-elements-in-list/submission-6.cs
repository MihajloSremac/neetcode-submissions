public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length];

        for(int i = 0; i < freq.Length; i++){
            freq[i] = new List<int>();
        }

        foreach(int n in nums){
            count[n] = count.GetValueOrDefault(n, 0) + 1;
        }

        foreach(var entry in count){
            freq[entry.Value - 1].Add(entry.Key);
        }

        int index = 0;
        int[] res = new int[k];
        for(int i = freq.Length - 1; i>=0; i--){
            foreach(var val in freq[i]){
                if(index == k)
                    break;
                res[index++] = val;
            }
        }

        return res;
    }
}
