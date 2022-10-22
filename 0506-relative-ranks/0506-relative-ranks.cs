public class Solution {
    public string[] FindRelativeRanks(int[] score) 
    {
        var result = new string[score.Length];
        var queue = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => y.CompareTo(x)));
        
        for(int i = 0; i < score.Length; i++)
            queue.Enqueue(i, score[i]);
        
        var count = 1;
        while(queue.Count != 0)
        {
            var index = queue.Dequeue();
            if(count == 1)
                result[index] = "Gold Medal";
            if(count == 2)
                result[index] = "Silver Medal";
            if(count == 3)
                result[index] = "Bronze Medal";
            
            if(count > 3)
                result[index] = count.ToString();
            
            count++;
        }
        
        return result;
    }
}