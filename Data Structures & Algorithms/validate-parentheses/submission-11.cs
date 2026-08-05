public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> closedToOpen =  new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        Stack<char> stack = new Stack<char>();

        foreach(char c in s){
            if(stack.Count > 0 && closedToOpen.ContainsKey(c)){
                if(stack.Peek() == closedToOpen[c])
                    stack.Pop();
                else{
                    return false;
                }
            }
            else
                stack.Push(c);
        }

        return stack.Count == 0;
    }
}
