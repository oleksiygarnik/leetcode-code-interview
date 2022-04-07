public class SeatManager 
{
    private PriorityQueue<int, int> pq;
    public SeatManager(int n) 
    {
        pq = new PriorityQueue<int, int>(new Comparer());
        for(int i = 1; i <= n; i++)
            pq.Enqueue(i, i);
    }
    
    public int Reserve() 
    {
        return pq.Dequeue();
        
//         if(pq.Count == 0)
//         {
//             pq.Enqueue(1, 1);
//             return 1;
//         }
//         else
//         {
//             var last = pq.Peek();
//             pq.Enqueue(last + 1, last + 1);
            
//             return last + 1;
//         }
    }
    
    public void Unreserve(int seatNumber) 
    {
        pq.Enqueue(seatNumber, seatNumber);
    }
}

public class Comparer : IComparer<int>
{
    public int Compare(int x, int y) => x.CompareTo(y);
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */