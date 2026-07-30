public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach(string str in strs)
            encoded = encoded + str.Length.ToString() + '#' + str;

        return encoded;
    }

    public List<string> Decode(string s) {
        
        List<string> res = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = i;

            while(s[j] != '#')
                j++;
            
            int toCut = int.Parse(s.Substring(i, j-i)); // 4#miha

            i = j + 1;
            res.Add(s.Substring(i, toCut));
            i += toCut;
        }

        return res;
   }
}
