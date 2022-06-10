public class Solution {
    public int CountGoodSubstrings(string s) 
    {
        var count = 0;
        for(int i = 0; i < s.Length - 2; i++)
        {
            var substring = s.Substring(i, 3);
            var unique = new HashSet<char>();
            foreach(var ch in substring)
            {
                if(unique.Contains(ch))
                    break;
                else
                    unique.Add(ch);
            }
            
            if(unique.Count() == 3)
                count++;
        }
        
        return count;
    }
}