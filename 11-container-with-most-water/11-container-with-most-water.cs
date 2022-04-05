public class Solution {
    public int MaxArea(int[] height) 
    {
        int left = 0, right = height.Length - 1, area = 0;
        while(left < right)
        {
            area = Math.Max(area, Math.Min(height[left], height[right])*(right - left));
            
            if(height[left] < height[right])
                left++;
            else
                right--;
        }
        
        return area;
    }
}