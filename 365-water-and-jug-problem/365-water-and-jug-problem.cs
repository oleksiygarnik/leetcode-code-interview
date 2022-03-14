public class Solution {
    public bool CanMeasureWater(int jug1Capacity, int jug2Capacity, int targetCapacity) 
    {
        if(jug1Capacity + jug2Capacity < targetCapacity)
            return false;
        
        var queue = new Queue<int>();
        queue.Enqueue(0);
        
        var visited = new HashSet<int>();
        visited.Add(0);
        
        var directions = new int[]{ jug1Capacity, -jug1Capacity, jug2Capacity, -jug2Capacity};
        
        while(queue.Count() > 0)
        {
            var size = queue.Count();
            while(size-- > 0)
            {
            var current = queue.Dequeue();
            
            if(current == targetCapacity)
                return true;
            
            foreach(var direction in directions)
            {
                var next = current + direction;
                
                if(next == targetCapacity)
                    return true;
                
                if(next < 0 || next > jug1Capacity + jug2Capacity)
                    continue;
                
                if(!visited.Contains(next))
                {
                    visited.Add(next);
                    queue.Enqueue(next);
                }
            }
            }
        }
        
        return false;
    }
}