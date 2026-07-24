public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

        foreach(string str in strs){
            int[] count = new int[26];
        
            foreach(char c in str){
                count[c - 'a']++;
            }

            string key = string.Join(',', count);

            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }

            res[key].Add(str);
        }            

        return res.Values.ToList<List<string>>();
    }
}
