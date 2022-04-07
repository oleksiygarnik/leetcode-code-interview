public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
        var pq = new PriorityQueue<int, int>(new Comparer());
        for(int i = 0; i < stones.Length; i++)
            pq.Enqueue(stones[i], stones[i]);
        
        while(pq.Count > 1)
        {
            var x = pq.Dequeue();
            var y = pq.Dequeue();
            if(x != y)
                pq.Enqueue(x - y, x - y);
        }
        
        return pq.Count == 1 ? pq.Dequeue() : 0;
    }
    
    public class Comparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}