public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        
        var result = string.Empty;
        var words = s.Split(new char[] { '-' });
        var length = words.Skip(1).SelectMany(x => x).Count();
        
        //if(length == 0)
        //    return Transform(words.Aggregate((x, y) => $"{x}{y}"), k);
        if(length != 0)
        {
            if(words.First().Count() > k)
                return Transform(words.Aggregate((x, y) => $"{x}{y}"), k);
            
            if(length % k == 0)
                result += words.First().ToUpper() + "-" + Transform(words.Skip(1).Aggregate((x, y) => $"{x}{y}"), k);
            else
            {
                var tmp = words.Aggregate((x, y) => $"{x}{y}");
                var skip = tmp.Length % k;
                result = tmp.Substring(0, skip).ToUpper() + "-" + Transform(tmp.Substring(skip, tmp.Length - skip), k);
            }
        }
        else{
            var length1 = words.SelectMany(x => x).Count();
            if(length1 % k == 0)
                result += Transform(words.Aggregate((x, y) => $"{x}{y}"), k);
            else
            {
                var tmp = words.Aggregate((x, y) => $"{x}{y}");
                var skip = tmp.Length % k;
                result = tmp.Substring(0, skip).ToUpper() + "-" + Transform(tmp.Substring(skip, tmp.Length - skip), k);
            }
        }
        
        return result.Trim(new char[] { '-'} );
    }
    
    private string Transform(string s, int k)
    {
        if(s == string.Empty)
            return s;
        
        var result = string.Empty;
        int count = k;
        for(int j = 0; j < s.Length; j++)
        {
            if(s[j] == '-')
                continue;
            
            result += char.ToUpper(s[j]).ToString();
            count--;
            
            if(count == 0)
            {
                count = k;
                result+="-";
            }
         }
        
        if(result[result.Length - 1] == '-')
            result = result.Substring(0, result.Length - 1);
        
        return result;
    }
}