public class Solution {
    public string SimplifyPath(string path) 
    {
        var folders = path.Split(new char[] { '/' } );
        var stack = new Stack<string>();
        
        for(int i = 0; i < folders.Length; i++)
        {
            if(folders[i] == "")
                continue;
            
            if(folders[i] == "." && folders[i].Length == 1)
                continue;
            
            if(folders[i] == "..")
            {
                if(stack.Count() != 0)
                    stack.Pop();
                
                continue;
            }
            
            stack.Push(folders[i]);
        }
        
        var result = string.Empty;
        
        var words = stack.ToList();
        words.Reverse();
        
        foreach(var word in words)
            result += "/" + word;
        
        return result == string.Empty ? "/" : result;
    }
}