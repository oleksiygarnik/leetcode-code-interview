public class Solution {
    public string MakeGood(string s) 
    {
        var stack = new Stack<char>();
        stack.Push(s[0]);
        int i = 1;
        while(i < s.Length)
        {
            if(stack.Count() > 0)
            {
                var prev = stack.Peek();
                if(char.IsUpper(prev) && char.IsLower(s[i]) && prev == char.ToUpper(s[i]))
                    stack.Pop();
                else if(char.IsLower(prev) && char.IsUpper(s[i]) && char.ToUpper(prev) == s[i])
                    stack.Pop();
                else
                    stack.Push(s[i]);
            }
            else
                stack.Push(s[i]);
                            
            i++;
        }
        
        var result = new StringBuilder();
        while(stack.Count() > 0)
            result.Append(stack.Pop().ToString());
        
        return Reverse(result.ToString());
    }
    
    private string Reverse(string str)
    {
        var result = "";
        for(int i = str.Length - 1; i >= 0; i--)
            result += str[i];
        
        return result;
           
    }
}