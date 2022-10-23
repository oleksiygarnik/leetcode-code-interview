public class Solution {
    public int NumberOfWeakCharacters(int[][] properties) 
    {
        Array.Sort(properties, 
                   Comparer<int[]>.Create(
                       (x, y) => x[0]- y[0] == 0 ? y[1]-x[1] : x[0]-y[0]));
        
        var stack = new Stack<int>();
        var result = 0;
        for(int i = 0; i < properties.Length; i++)
        {
            while(stack.Count() > 0 && properties[stack.Peek()][0] < properties[i][0])
            {
                if(properties[stack.Peek()][1] >= properties[i][1])
                    break;
                
                result++;
                stack.Pop();
            }
            
            stack.Push(i);
        }
        
        return result;
    }
}