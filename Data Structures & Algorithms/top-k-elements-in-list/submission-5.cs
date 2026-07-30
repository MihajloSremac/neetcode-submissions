public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> count = new Dictionary<int,int>();

        foreach(int n in nums)
            count[n] = count.GetValueOrDefault(n, 0) + 1;
        
        List<int>[] freq = new List<int>[nums.Length];

        for(int i = 0; i < freq.Length; i++)
            freq[i] = new List<int>();

        foreach(var entry in count){
            freq[entry.Value - 1].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(int i = nums.Length - 1; i>=0; i--){
            foreach(var num in freq[i]){
                res[index++] = num;
                if(index == k)
                    return res;
            }

        }
        return res;
    }
}
