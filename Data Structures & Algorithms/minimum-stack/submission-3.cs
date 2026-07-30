public class MinStack {
    Stack<long> stack;
    long min;

    public MinStack() {
        stack = new Stack<long>();
    }

    public void Push(int val) {
        if (stack.Count == 0) {
            min = val;
            stack.Push(0L);
        } else {
            stack.Push(val - min);
            if (val < min)
                min = val;
        }
    }

    public void Pop() {
        if (stack.Peek() < 0) {
            min = min - stack.Peek();
            stack.Pop();
        }
        else stack.Pop();
    }

    public int Top() {
        return stack.Peek() > 0 ? (int)(stack.Peek() + min) : (int) min;
    }

    public int GetMin() {
        return (int)min;
    }
}
