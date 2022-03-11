public class Solution {
    public int SubtractProductAndSum(int n) 
    {
        var product = 1;
        var sum = 0;
        foreach(var digit in n.ToString())
        {
            int num = digit - '0';
            product *= num;
            sum += num;
        }
        
        return product - sum;
    }
}