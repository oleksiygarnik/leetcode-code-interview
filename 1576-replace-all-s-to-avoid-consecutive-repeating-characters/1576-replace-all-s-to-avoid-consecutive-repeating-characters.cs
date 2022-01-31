public class Solution {
    public string ModifyString(string s) {
        if(s.Length == 1 && s == "?")
            return "a";
        
        var sb = new StringBuilder();
        
        var arr = s.ToCharArray();
        for(int i = 0; i < s.Length; i++)
        {
            if(arr[i] != '?')
            {
                sb.Append(arr[i].ToString());
                continue;
            }
            
            if(i == 0 && arr[i] == '?')
            {
               for(char j = 'a'; j < 'z'; j++)
                {
                    if(arr[i + 1] != j)
                    {
                        arr[i] = j;
                        sb.Append(j.ToString());
                        break;
                    }
                }
                
                continue;
            }
            
            if(i == s.Length - 1 && s[i] == '?')
            {
                for(char j = 'a'; j < 'z'; j++)
                {
                    if(arr[i - 1] != j)
                    {                
                        arr[i] = j;
                        sb.Append(j.ToString());
                        break;
                    }
                }
                
                continue;
            }
            
            sb.Append(PickAtRandom(arr, i));
        }
        
        return sb.ToString();
    }
    
    private string PickAtRandom(char[] s, int i)
    {
        for(char j = 'a'; j < 'z'; j++)
        {
            if(s[i - 1] != j && s[i + 1] != j)
            {
                s[i] = j;
                return j.ToString();
            }
        }
        
        return string.Empty;
    }
}