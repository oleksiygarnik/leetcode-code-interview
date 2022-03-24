public class Solution {
    public int LastStoneWeight(int[] stones) {
        if(stones.Length == 1)
            return stones[0];
        
        var pq = new PriorityQueue<int, int>(new Comparer());
        
        for(int i = 0; i < stones.Length; i++)
            pq.Enqueue(stones[i], stones[i]);
        
        Console.WriteLine(pq.Count);
        while(pq.Count > 1)
        {
            var left = pq.Dequeue();
            var right = pq.Dequeue();
            
            if(left != right)
            {
                var diff = left - right;
                pq.Enqueue(diff, diff);
            }
        }
        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
    
    public class Comparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}