public class Solution {
    public int ArrangeCoins(int n) 
    {
        int count = 0;
        int temp = 1;
        while(n >= 0)
        {
            n -= temp;
            temp++;
            
            if(n >= 0)
                count++;
        }
        
        return count;
    }
}