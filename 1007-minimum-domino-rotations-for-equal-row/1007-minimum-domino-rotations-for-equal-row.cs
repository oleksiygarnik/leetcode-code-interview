public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) 
    {
        var freq = new int[6];
        for(int i = 0; i < tops.Length; i++)
        {
            freq[tops[i] - 1]++;
            freq[bottoms[i] - 1]++;
        }
        
        var value = freq[0]; 
        var freqValue = 1;
        for(int i = 1; i < freq.Length; i++)
        {
            if(value < freq[i])
            {
                value = freq[i];
                freqValue = i + 1;
            }
        }
        
        var topCount = 0;
        var bottomCount = 0;
        for(int i = 0; i < tops.Length; i++)
        {
            if(tops[i] != freqValue && bottoms[i] != freqValue)
                return -1;
            
            if(tops[i] != freqValue)
                topCount++;
            
            if(bottoms[i] != freqValue)
                bottomCount++;
        }
        
        return Math.Min(topCount, bottomCount);
    }
}