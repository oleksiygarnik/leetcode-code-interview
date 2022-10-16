public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        var prefix = string.Empty;
        var ordered = strs.OrderBy(x => x.Length).ToArray();
        var index = 0;
        var maxIndex = ordered.First().Length;
        while(index < maxIndex)
        {
            for(int i = 0; i < ordered.Count() - 1; i++)
            {
                if(ordered[i][index] != ordered[i + 1][index])
                    return prefix;
            }
            
            prefix += ordered[0][index];
            index++;
        }
        
        return prefix;
    }
}