public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var max = 0;
        for(int i = 0; i < accounts.Length; i++)
        {
            var current = 0;
            for(int j = 0; j < accounts[i].Length; j++)
                current += accounts[i][j];
            
            max = Math.Max(max, current);
        }
        
        return max;
    }
}