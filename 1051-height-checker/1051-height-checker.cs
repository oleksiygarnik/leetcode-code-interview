public class Solution {
    public int HeightChecker(int[] heights) 
    {
        var copy = new int[heights.Length];
        Array.Copy(heights, copy, heights.Length);
        QuickSort(heights, 0, heights.Length - 1);
        
        var result = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if(heights[i] != copy[i])
                result++;
        }
        
        return result;
    }
    
    private int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        
        while(i <= j)
        {
            while (array[i] < pivot)
                i++;
        
            while (array[j] > pivot)
                j--;
            
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
        
        if (leftIndex < j)
            QuickSort(array, leftIndex, j);
        if (i < rightIndex)
            QuickSort(array, i, rightIndex);
        
        return array;
    }
}