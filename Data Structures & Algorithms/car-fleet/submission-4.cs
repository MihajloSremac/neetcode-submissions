public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pairs = new int [position.Length][];

        for(int i = 0; i < position.Length; i++){
            pairs[i] = [position[i], speed[i]];
        }

        Array.Sort(pairs, (a, b) => b[0].CompareTo(a[0]));

        Stack<double> stack = new Stack<double>();
        for(int i = 0; i < pairs.Length; i++){
            stack.Push((double)(target-pairs[i][0])/pairs[i][1]);

            if(stack.Count > 1 && stack.ElementAt(1) >= stack.Peek())
                stack.Pop();
        }

        return stack.Count;
    }
}
