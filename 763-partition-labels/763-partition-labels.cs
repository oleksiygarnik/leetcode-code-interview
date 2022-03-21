public class Solution {
    public IList<int> PartitionLabels(string s) 
    {
        var dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
                dict[s[i]]++;
            else
                dict.Add(s[i], 1);
       }
        
        var unique = new HashSet<char>();
        var result = new List<int>();
        var left = 0;
        for(int i = 0; i < s.Length; i++)
        {
            unique.Add(s[i]);
            
            if(dict[s[i]] == 1)
            {
                dict.Remove(s[i]);
                unique.Remove(s[i]);
                
                if(unique.Count() == 0)
                {
                    result.Add(i + 1 - left);
                    left = i + 1;
                }
            }
            else
                dict[s[i]]--;
        }
        
        return result;
    }
}