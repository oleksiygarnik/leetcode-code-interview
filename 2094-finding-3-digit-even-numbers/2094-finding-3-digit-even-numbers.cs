public class Solution {
    public int[] FindEvenNumbers(int[] digits) 
    {
        var result = new HashSet<int>();
        for(int i = 0; i < digits.Length; i++)
        {
            if(digits[i] == 0)
                continue;
            
            for(int j = 0; j < digits.Length; j++)
            {
                for(int k = 0; k < digits.Length; k++)
                {
                    if(i == j || i == k || j == k)
                        continue;
                    
                    var res = digits[i] * 100 + digits[j] * 10 + digits[k];
                    if(res % 2 == 0)
                        result.Add(res);
                }
            }
        }
        
        return result.OrderBy(x => x).ToArray();
    }
}