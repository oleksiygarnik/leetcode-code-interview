public class Solution {
    public int NumberOfSubstrings(string s) 
    {
        var dict = new Dictionary<char, int>();
        int left = 0, right = 0, result = 0;
        
        var indx = new Dictionary<int, int>();
        
        while(right < s.Length)
        {
            if(dict.ContainsKey(s[right]))
                dict[s[right]]++;
            else
                dict.Add(s[right], 1);
            
            while(dict.Keys.Count() == 3)
            {
                result += s.Length - right;
                dict[s[left]]--;
                
                if(dict[s[left]] == 0)
                    dict.Remove(s[left]);
                
                left++;
            }
            
            right++;
        }
        
        return result;
    }
}