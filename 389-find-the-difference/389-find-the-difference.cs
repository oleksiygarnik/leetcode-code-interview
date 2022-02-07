public class Solution {
    public char FindTheDifference(string s, string t) 
    {
        var dict = new Dictionary<char, int>();
        foreach(var ch in s)
        {
            if(dict.ContainsKey(ch))
                dict[ch]++;
            else
                dict.Add(ch, 1);
        }
        
        foreach(var ch in t)
        {
            if(dict.TryGetValue(ch, out var res))
            {
                dict[ch] = --res;
                if(res == 0)
                    dict.Remove(ch);
            }
            else
               return ch;
        }
               
        return 'a';
    }
}