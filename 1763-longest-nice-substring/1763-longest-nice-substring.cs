public class Solution {
    public string LongestNiceSubstring(string s) 
    {
        var unique = GetUniqueChars(s);
        
        var maxLength = 0;
        var max = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
            if(unique.Contains(ToLower(s[i])))
                continue;
            
            for(int j = i; j < s.Length; j++)
            {
                if(unique.Contains(ToLower(s[j])))
                    break;
                
                var substring = s.Substring(i, j - i + 1);
                if(substring.Length <= maxLength)
                    continue;
                
                if(IsNice(substring))
                {
                    max = Math.Max(maxLength, substring.Length) == maxLength
                        ? max 
                        : substring;
                    
                    maxLength = max.Length;
                }
            }
        }
        
        return max;
    }

    private List<char> GetUniqueChars(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach(var ch in s)
        {
            var key = Char.ToLower(ch);
            
            if(dict.ContainsKey(key))
                dict[key]++;
            else
                dict.Add(key, 1);
        }
        
        return dict.Where(x => x.Value == 1)
            .Select(x => x.Key)
            .ToList();
    }
    
    private bool IsNice(string s)
    {
        var missing = new HashSet<char>();
        var seen = new HashSet<char>();
        
        foreach(var ch in s)
        {
            seen.Add(ch);

            var need = Char.IsLower(ch) 
                ? (char)(ch - 32) 
                : (char)(ch + 32);
            
            if(missing.Contains(ch))
                 missing.Remove(ch);
            if(seen.Contains(need))
                continue;
            else
                missing.Add(need);
        }
        
        return missing.Count() == 0;
    }
    
    private static char ToLower(char ch) => 
        Char.IsLower(ch) 
            ? ch 
            : (char)(ch - 32);
}