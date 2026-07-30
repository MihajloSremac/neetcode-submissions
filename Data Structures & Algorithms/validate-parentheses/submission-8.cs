public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> closeToOpen = new Dictionary<char,char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        Stack<char> stack = new Stack<char>();
        foreach(char str in s){
            if(closeToOpen.ContainsKey(str)){
                if(stack.Count > 0 && stack.Peek() == closeToOpen[str])
                    stack.Pop();
                else
                    return false;
            }
            else
                stack.Push(str);
        }

        return stack.Count == 0;
    }
}
