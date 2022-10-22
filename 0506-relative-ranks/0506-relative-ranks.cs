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
            result[index] = count switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => count.ToString()
            };
            
            count++;
        }
        
        return result;
    }
}