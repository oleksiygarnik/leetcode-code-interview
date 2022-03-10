public class Solution {
    public int CountOdds(int low, int high) 
    {
        var diff = high - low + 1;
        if(diff%2 == 0)
            return diff/2;
        else 
        {
            if(high%2 == 0)
                return diff/2;
            else
                return diff/2 + 1;
        }
    }
}