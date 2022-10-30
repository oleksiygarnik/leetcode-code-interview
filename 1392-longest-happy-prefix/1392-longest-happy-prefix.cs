public class Solution {
    public string LongestPrefix(string s) 
    {
        return s.Substring(0, CreatePrefixFunction(s)[^1]);
    }
    
    private int[] CreatePrefixFunction(string pattern)
    {
        var prefix = new int[pattern.Length];
        var i = 0; 
        var j = 1;
        
        prefix[i] = 0;
        
        while(j < pattern.Length)
        {
            if(pattern[i] == pattern[j])
            {
                prefix[j] = i + 1;
                i++;
                j++;
            }
            else
            {
                if(i == 0)
                {
                    prefix[j] = 0;
                    j++;
                }
                else
                    i = prefix[i - 1];
            }
        }
        
        return prefix;
    }
}