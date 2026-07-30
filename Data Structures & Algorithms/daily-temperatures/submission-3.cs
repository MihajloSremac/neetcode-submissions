public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];

        Stack<int[]> stack = new Stack<int[]>();

        for(int i = 0; i < temperatures.Length; i++){
            if(stack.Count == 0)
                stack.Push([temperatures[i], i]);
            else{
                while(stack.Count > 0 && temperatures[i] > stack.Peek()[0]){
                    res[stack.Peek()[1]] = i - stack.Peek()[1];
                    stack.Pop();
                }
                stack.Push([temperatures[i], i]);
            }
        }
        
        return res;
    }
}
