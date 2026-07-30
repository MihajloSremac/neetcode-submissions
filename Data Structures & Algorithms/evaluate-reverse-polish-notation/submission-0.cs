public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new Stack<int>();

        foreach(string token in tokens){
            if(token != "*" && token != "+" && token != "-" && token != "/"){
                stack.Push(int.Parse(token));
            }
            else{
                int b = stack.Pop();
                int a = stack.Pop();

                if(token == "+") stack.Push(a+b);
                if(token == "-") stack.Push(a-b);
                if(token == "*") stack.Push(a*b);
                if(token == "/") stack.Push(a/b);
                
            }
        }

        return stack.Pop();
    }
}
