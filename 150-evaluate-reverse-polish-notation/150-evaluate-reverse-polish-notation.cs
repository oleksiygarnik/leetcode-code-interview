public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        var stack = new Stack<int>();
        
        for(int i = 0; i < tokens.Length; i++)
        {
            if(tokens[i].Length > 1 || (tokens[i][0] >= '0' && tokens[i][0] <= '9'))
                stack.Push(int.Parse(tokens[i]));
            else
            {
                var first = stack.Pop();
                var second = stack.Pop();
                
                var result = tokens[i][0] switch
                {
                    '+' => first + second,
                    '*' => first * second,
                    '/' => second / first,
                    '-' => second - first
                };
                
                stack.Push(result);
            }
        }
        
        return stack.Pop();
    }
}