public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<int>();
        for(int i = 0; i < temperatures.Length; i++)
        {
            while(stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int prevDay = stack.Pop();
                result[prevDay] = i - prevDay;
            }
            
            stack.Push(i);
        }
        
        return result;
    }
}