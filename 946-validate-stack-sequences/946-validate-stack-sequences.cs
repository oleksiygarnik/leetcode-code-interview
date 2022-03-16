public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) 
    {
        var stack = new Stack<int>();
        int j = 0;

        for(int i = 0; i < pushed.Length; i++)
        {
            stack.Push(pushed[i]);
            
            while(stack.Count() > 0 && j < popped.Length && popped[j] == stack.Peek())
            {
                stack.Pop();
                j++;
            }
        }
        
        return pushed.Length == j;
    }
}