public class Solution {
    public int EvalRPN(string[] tokens) {
        HashSet<string> signs = new HashSet<string>
        {
            "+", 
            "-", 
            "*", 
            "/"
        };

        Stack<int> stack = new Stack<int>();

        foreach(string str in tokens)
        {
            if(!signs.Contains(str))
                stack.Push(int.Parse(str));
            else{
                int a = stack.Pop();
                int b = stack.Pop();

                if(str == "+")
                    stack.Push(a+b);
                else if(str == "-")
                    stack.Push(b-a);
                else if(str == "*")
                    stack.Push(a*b);
                else
                    stack.Push(b/a);
            }
        }
        return stack.Pop();
    }
}
