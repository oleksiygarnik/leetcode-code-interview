public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var dict = new Dictionary<string, int>();
        
        for(int i = 0; i < emails.Length; i++)
        {
            bool isLocal = true;
            var local = string.Empty;
            for(int j = 0; j < emails[i].Length; j++)
            {
                if(emails[i][j] == '@')
                    isLocal = false;
            
                if(isLocal)
                {
                    if(emails[i][j] == '.')
                        continue;
                    if(emails[i][j] == '+')
                    {
                        while(emails[i][j] != '@')
                            j++;
                        
                        isLocal = false;
                    }
                }
                
                local+=emails[i][j];
            }
            
            if(dict.TryGetValue(local, out var res))
                dict[local] = ++res;
            else
                dict.Add(local, 1);
        }
        
        return dict.Keys.Count();
    }
}