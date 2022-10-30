public class Solution {
    public IList<bool> CamelMatch(string[] queries, string pattern) 
    {
        var result = new bool[queries.Length];
        for(int i = 0; i < queries.Length; i++)
            result[i] = IsMatch(queries[i], pattern);
        
        return result;
    }
    
    private bool IsMatch(string word, string pattern)
    {
        int i = 0;
        
            for(int j = 0; j < word.Length; j++)
            {
                if(pattern[i] == word[j])
                {
                    i++;
                    if(i == pattern.Length)
                    {
                        foreach(var ch in word.Substring(j + 1, word.Length - j - 1))
                        {
                            if(char.IsUpper(ch))
                                return false;
                        }
                        
                        return true;
                    }
                }
                else
                {
                    if(char.IsUpper(word[j]))
                        return false;
                }
            }
            
        
        return false;
    }
}