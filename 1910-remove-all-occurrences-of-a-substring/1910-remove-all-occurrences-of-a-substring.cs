public class Solution {
    public string RemoveOccurrences(string s, string part) 
    {
        while(true)
        {
            var index = s.IndexOf(part);
            if(index == -1)
                return s;
            else
                s = s.Remove(index, part.Length);
        }
        
        return string.Empty;
    }
}