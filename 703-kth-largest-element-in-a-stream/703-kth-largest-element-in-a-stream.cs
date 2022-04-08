public class KthLargest 
{
    private PriorityQueue<int, int> pq;
    private int K;
    
    public KthLargest(int k, int[] nums) 
    {
        pq = new PriorityQueue<int, int>();
        for(int i = 0; i < nums.Length; i++)
            pq.Enqueue(nums[i], nums[i]);
        
        while(pq.Count > k)
            pq.Dequeue();
        
        K = k;
    }
    
    public int Add(int val) 
    {
        pq.Enqueue(val, val);
         while(pq.Count > K)
            pq.Dequeue();
        
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */