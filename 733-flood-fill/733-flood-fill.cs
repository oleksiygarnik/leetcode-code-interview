public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) 
    {
        int color = image[sr][sc];
        if(color != newColor)
            Dfs(image, sr, sc, color, newColor);
        
        return image;
    }
    
    private void Dfs(int[][] image, int sr, int sc, int color, int newColor)
    {
        if(image[sr][sc] == color)
        {
            image[sr][sc] = newColor;
            if(sr >= 1) Dfs(image, sr - 1, sc, color, newColor);
            if(sc >= 1) Dfs(image, sr, sc - 1, color, newColor);
            if(sr < image.Length - 1) Dfs(image, sr + 1, sc, color, newColor);
            if(sc < image[0].Length - 1) Dfs(image, sr, sc + 1, color, newColor);
        }
    }
}