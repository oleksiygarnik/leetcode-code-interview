public class Solution {
    public bool CanReach(int[] arr, int start) 
    {
        var stack = new Stack<int>();
        stack.Push(start);
        
        var visited = new bool[arr.Length];
        
        while(stack.Count() > 0)
        {
            var current = stack.Pop();
            
            if(arr[current] == 0)
                return true;
            
            var forward = current + arr[current];
            var backward = current - arr[current];
            
            if(forward <= arr.Length - 1)
            {
                if(!visited[forward])
                {
                    visited[forward] = true;
                    stack.Push(forward);
                }
            }
            
            if(backward >= 0)
            {
                if(!visited[backward])
                {
                    visited[backward] = true;
                    stack.Push(backward);
                }
            }
        }
        
        return false;
    }
}