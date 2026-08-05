public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int[]> stack = new Stack<int[]>();

        int[] res = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++){
            while(stack.Count > 0 && stack.Peek()[0] < temperatures[i]){
                int[] temp = stack.Pop();
                res[temp[1]] = i - temp[1];
            }
            stack.Push([temperatures[i], i]);
        }

        return res;
    }
}
