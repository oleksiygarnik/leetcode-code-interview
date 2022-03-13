public class Solution {
    public bool IsValid(string s) 
    {
        var openBrackets = new char[]{ '(', '{', '[' };
        var stack = new Stack<char>();
        stack.Push(s[0]);
        
        for(int i = 1; i < s.Length; i++)
        {
            if(openBrackets.Contains(s[i]))
            {
                stack.Push(s[i]);
                continue;
            }
            else
            {
                if(stack.Count == 0)
                    return false;
                
                var openBracket = stack.Pop();
                
                if(s[i] == ')' && openBracket == '(')
                    continue;
                else if(s[i] == '}' && openBracket == '{')
                    continue;
                else if(s[i] == ']' && openBracket == '[')
                    continue;
                else
                    return false;
            }
        }
        
        return stack.Count() == 0;
    }
}