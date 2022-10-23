public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => y.CompareTo(x)));
        
        for(int i = 0; i < nums.Length; i++)
            queue.Enqueue(nums[i], nums[i]);
        
        int result = 0;
        while(k-- != 0)
            result = queue.Dequeue();
        
        return result;
    }
}