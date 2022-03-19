public class Solution {
    public string FreqAlphabets(string s) 
    {
        var sb = new StringBuilder();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(i < s.Length - 2 && s[i + 2] == '#')
            {
                var start = i;
                var end = i + 2;
                sb.Append((char)(int.Parse(s[start..end]) + 'a' - 1));
                i+=2;
            }
            else
                sb.Append((char)(s[i] - '0' + 'a' - 1));
        }
        
        return sb.ToString();
    }
}