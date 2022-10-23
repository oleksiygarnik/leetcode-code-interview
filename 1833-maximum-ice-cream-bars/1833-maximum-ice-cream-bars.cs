public class Solution {
    public int MaxIceCream(int[] costs, int coins) 
    {
        var result = 0;
        Array.Sort(costs);
        for(int i = 0; i < costs.Length; i++)
        {
            coins -= costs[i];
            if(coins < 0)
                return result;
            
            result++;
        }
        
        return result;
    }
}