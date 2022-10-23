public class Solution {
    public int FindLUSlength(string[] strs) 
    {
        var max = -1;
        for(int i = 0; i < strs.Length; i++)
        {
            var isSubsequence = false;
            for(int j = 0; j < strs.Length; j++)
            {
                if(i == j)
                    continue;
                
                if(IsSubsequence(strs[i], strs[j]))
                {
                    isSubsequence = true;
                    break;
                }
            }
            
            if(!isSubsequence)
                max = Math.Max(max, strs[i].Length);
        }
        
        return max;
    }
    
    private bool IsSubsequence(string first, string second)
    {
        var left = 0;
        for(int i = 0; i < second.Length; i++)
        {
            if(first[left] == second[i])
            {
                left++;
                if(left == first.Length)
                    return true;
            }
        }
        
        return false;
    }
}