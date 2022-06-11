public class Solution {
    public string LongestNiceSubstring(string s) 
    {
        var max = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
            for(int j = i; j < s.Length; j++)
            {
                var substring = s.Substring(i, j - i + 1);
                
                if(IsNice(substring))
                {
                    max = Math.Max(max.Length, substring.Length) == max.Length
                        ? max 
                        : substring;
                }
            }
        }
        
        return max;
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
}