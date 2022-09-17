public class Solution {
    public string FrequencySort(string s) 
    {
        if(s.Length == null || s.Length <= 1)
            return s;
        
        var dict = new Dictionary<char, int>();
        
        foreach(var ch in s)
        {
            if(dict.ContainsKey(ch))
                dict[ch]++;
            else
            {
                dict.Add(ch, 1);
            }
        }
        
        var sb = new StringBuilder();
        foreach(var tuple in dict.OrderByDescending(x => x.Value))
        {
            for(int i = 0; i < tuple.Value; i++)
                sb.Append(tuple.Key.ToString());
        }
        
        return sb.ToString();
    }
}