public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var dict = new Dictionary<string, IList<string>>();
        
        foreach(var str in strs)
        {
            var chars = new char[26];
            foreach(var ch in str)
            {
                chars[ch - 'a']++;
            }
            
            var result = new string(chars);
             
            if(dict.ContainsKey(result))
                dict[result].Add(str);
            else
                dict.Add(result, new List<string>(){ str });
        }
        
        return dict.Values.ToList();
    }
}