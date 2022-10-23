public class Solution {
    public int MinimumCost(int[] cost) 
    {
        if(cost.Length == 1)
            return cost[0];
        if(cost.Length == 2)
            return cost[0] + cost[1];
        
        Array.Sort(cost);
        var result = 0;
        for(int i = cost.Length - 1; i >= 0; i-=3)
            result += i == 0 ? cost[0] : (cost[i] + cost[i - 1]);
        
        return result;
    }
}