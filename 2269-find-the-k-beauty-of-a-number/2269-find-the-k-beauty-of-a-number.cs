public class Solution {
    public int DivisorSubstrings(int num, int k) 
    {
        int result = 0;
        var numToString = num.ToString();
        for(int i = 0; i <= numToString.Length - k; i++)
        {
            var substring = numToString.Substring(i, k);
            var substringToInt = int.Parse(substring);
            
            if(substringToInt == 0)
                continue;
            
            if(num % substringToInt == 0)
                result++;
        }
        
        return result;
    }
}