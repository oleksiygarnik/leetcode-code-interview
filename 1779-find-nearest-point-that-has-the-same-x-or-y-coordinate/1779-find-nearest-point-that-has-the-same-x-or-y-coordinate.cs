public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) 
    {
        var minDistance = int.MaxValue;
        var minIndex = -1;
        
        for(int i = 0; i < points.Length; i++)
        {
            if(x == points[i][0] || y == points[i][1])
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                
                var distance = Math.Abs(x1 - x) + Math.Abs(y1 - y);
                if(minDistance > distance)
                {
                    minDistance = distance;
                    minIndex = i;
                }
            }
        }
        
        return minIndex;
    }
}