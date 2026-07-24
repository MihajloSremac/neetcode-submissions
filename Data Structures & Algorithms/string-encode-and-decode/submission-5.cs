public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach(string str in strs){
            encoded += str.Length + "#" + str;
        }

        return encoded;
    }

    public List<string> Decode(string s) {

        List<string> res = new List<string>();

        int i = 0;
        while(i < s.Length){
            int j = i;

            while(s[j] != '#'){ //4#miha3#nig
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;
            res.Add(s.Substring(i, length));

            i = j = i + length;
        }
        return res;
   }
}
