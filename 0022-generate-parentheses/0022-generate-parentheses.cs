public class Solution {
    public IList<string> GenerateParenthesis(int n) 
    {
        var result = new HashSet<(string, int, int)>();
        result.Add(("(", n - 1, n));
        
        while(result.All(x => x.Item2 != 0 || x.Item3 != 0))
        {
            var next = new HashSet<(string, int, int)>();
            foreach(var current in result)
            {
                if(current.Item2 == 0 && current.Item3 == 0)
                {
                    next.Add((current.Item1, current.Item2, current.Item3));
                    continue;
                }
                    
                next.Add((current.Item1 + ")", current.Item2, current.Item3 - 1));
                next.Add((current.Item1 + "(", current.Item2 - 1, current.Item3));
            }
            
            result = next;
        }
        
        return result.Select(x => x.Item1).Where(IsValid).ToList();
    }
    
    public bool IsValid(string word)
    {
        var stack = new Stack<char>();
        for(int i = 0; i < word.Length; i++)
        {
            if(stack.Count() == 0)
            {
                if(word[i] == ')')
                    return false;
                else
                    stack.Push(word[i]);
            }
            else
            {
                if(word[i] == ')')
                    stack.Pop();
                else
                    stack.Push(word[i]);
            }
        }
        
        return stack.Count() == 0;
    }
}