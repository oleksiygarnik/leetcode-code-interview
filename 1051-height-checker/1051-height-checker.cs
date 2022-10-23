public class Solution {
    public int HeightChecker(int[] heights) 
    {
        var copy = new int[heights.Length];
        Array.Copy(heights, copy, heights.Length);
        Array.Sort(heights);
        
        var result = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if(heights[i] != copy[i])
                result++;
        }
        
        return result;
    }
}