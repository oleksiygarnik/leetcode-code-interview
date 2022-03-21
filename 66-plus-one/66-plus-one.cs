public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        var result = new List<int>();;
        var bonus = 1;
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            var num = digits[i] + bonus;
            bonus = num / 10;
            
            result.Add(num % 10);
        }
        
        if(bonus != 0)
            result.Add(bonus);
        
        result.Reverse();
        return result.ToArray();
    }
}